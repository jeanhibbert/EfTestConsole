namespace EfTestConsole.Demonstration
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Reflection;

    using Dapper;

    using EfTestConsole.Benchmarks;

    public static class EfBenchmarks
    {
        #region Constants

        private const int IndividualKeysAmount = 10;
        
        private const int LoopAmount = 2;

        private const bool PerformEagerLoadBenchmarks = true;
                           // flag to signal whether the eager load fetch benchmarks have to be run. Not every bencher will perform this benchmnark.

        private const bool PerformIndividualBenchMarks = true;
                           // flag to signal whether the single element fetch benchmarks have to be run.

        private const bool PerformSetBenchmarks = true;
                           // flag to signal whether the set fetch benchmarks have to be run.

        #endregion

        #region Static Fields

        private static readonly List<IBencher> RegisteredBenchers = new List<IBencher>();

        private static string ConnectionString =
            ConfigurationManager.ConnectionStrings["AdventureWorksContext"].ConnectionString;

        private static List<int> KeysForIndividualFetches = new List<int>();

        private static string SqlSelectCommandText =
            @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber],[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID],[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate]	FROM [Sales].[SalesOrderHeader]";

        #endregion

        #region Public Methods and Operators

        public static Assembly GetAssembly(Type type)
        {
            return type.Assembly;
        }

        public static Version GetVersion(Type type)
        {
            return GetAssembly(type).GetName().Version;
        }

        public static void RunBenchmarks()
        {
            bool autoExit = false;
            InitConnectionString();

            RegisteredBenchers.Add(
                new RawDbDataReaderBencher
                    {
                        CommandText = SqlSelectCommandText,
                        ConnectionStringToUse = ConnectionString
                    });
            RegisteredBenchers.Add(
                new DapperBencher { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });

            RegisteredBenchers.Add(new EntityFrameworkNoChangeTrackingBencher());
            RegisteredBenchers.Add(new EntityFrameworkNormalBencher());
            RegisteredBenchers.Add(
                new DataTableBencher { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
            RegisteredBenchers.Add(new MassiveBencher());
            DisplayHeader();

            WarmupDB();
            FetchKeysForIndividualFetches();

            RunRegisteredBenchers();
            ReportResultStatistics(autoExit);
        }

        #endregion

        #region Methods

        private static void DisplayBencherInfo(IBencher bencher)
        {
            DisplayBencherInfo(bencher, "\n", suffixWithDashLine: true);
        }

        private static void DisplayBencherInfo(IBencher bencher, string linePrefix, bool suffixWithDashLine)
        {
            Console.Write(linePrefix);
            Console.WriteLine(
                "{0}. Change tracking: {1}. Caching: {2}.",
                bencher.CreateFrameworkName(),
                bencher.UsesChangeTracking,
                bencher.UsesCaching);
            if (suffixWithDashLine)
            {
                Console.WriteLine(
                    "--------------------------------------------------------------------------------------------");
            }
        }

        private static void DisplayException(Exception toDisplay)
        {
            if (toDisplay == null)
            {
                return;
            }

            Console.WriteLine("Exception caught of type: {0}", toDisplay.GetType().FullName);
            Console.WriteLine("Message: {0}", toDisplay.Message);
            Console.WriteLine("Stack trace:\n{0}", toDisplay.StackTrace);
            Console.WriteLine("Inner exception:");
            DisplayException(toDisplay.InnerException);
        }

        private static void DisplayHeader()
        {
            bool releaseBuild = true;
            releaseBuild = false;
            var conBuilder = new SqlConnectionStringBuilder(ConnectionString);
            string sqlServerVersion = "Unknown";
            using (var conForHeader = new SqlConnection(ConnectionString))
            {
                conForHeader.Open();
                sqlServerVersion = conForHeader.ServerVersion;
                conForHeader.Close();
            }

            Console.WriteLine(
                "+-------------------------------------------------------------------------------------------");
            Console.WriteLine("| Raw Data Access / ORM Benchmarks.");
            Console.WriteLine(@"| Code available at              : https://github.com/FransBouma/RawDataAccessBencher");
            Console.WriteLine("| Benchmarks run on              : {0}", DateTime.Now.ToString("F"));
            Console.WriteLine("| Registered benchmarks          :");
            foreach (IBencher bencher in RegisteredBenchers)
            {
                DisplayBencherInfo(bencher, "| \t", suffixWithDashLine: false);
            }
            Console.WriteLine("| Run set benchmarks             : {0}", PerformSetBenchmarks);
            Console.WriteLine("| Run individual fetch benchmarks: {0}", PerformIndividualBenchMarks);
            Console.WriteLine("| Number of set fetches          : {0}", LoopAmount);
            Console.WriteLine("| Number of individual keys      : {0}", IndividualKeysAmount);
            Console.WriteLine("| Release build                  : {0}", releaseBuild);
            Console.WriteLine(
                "| Client OS                      : {0} ({1}bit)",
                Environment.OSVersion,
                Environment.Is64BitOperatingSystem ? "64" : "32");
            Console.WriteLine("| Bencher runs as 64bit          : {0}", Environment.Is64BitProcess);
            Console.WriteLine("| CLR version                    : {0}", Environment.Version);
            Console.WriteLine("| Number of CPUs                 : {0}", Environment.ProcessorCount);
            Console.WriteLine("| Server used                    : {0}", conBuilder.DataSource);
            Console.WriteLine("| Catalog used                   : {0}", conBuilder.InitialCatalog);
            Console.WriteLine("| SQL Server version used        : {0}", sqlServerVersion);
            Console.WriteLine(
                "+-------------------------------------------------------------------------------------------\n");
        }

        private static void FetchKeysForIndividualFetches()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                KeysForIndividualFetches =
                    conn.Query<int>(
                        "select top {=count} SalesOrderId from AdventureWorks.Sales.SalesOrderHeader order by SalesOrderNumber",
                        new { count = IndividualKeysAmount }).AsList();
            }
            if (KeysForIndividualFetches.Count != IndividualKeysAmount)
            {
                throw new InvalidOperationException("Can't fetch the keys for the individual benchmarks");
            }
        }

        private static void InitConnectionString()
        {
            ConnectionStringSettings connectionStringFromConfig =
                ConfigurationManager.ConnectionStrings["AdventureWorksContext"];
            if (connectionStringFromConfig != null)
            {
                ConnectionString = string.IsNullOrEmpty(connectionStringFromConfig.ConnectionString)
                                       ? ConnectionString
                                       : connectionStringFromConfig.ConnectionString;
            }
        }

        /// <summary>
        ///     Displays a pre-amble so the user can attach the .net profiler, then runs the benchers specified and then displays a text to stop profiling.
        /// </summary>
        /// <param name="benchersToProfile">The benchers to profile.</param>
        private static void ProfileBenchers(params IBencher[] benchersToProfile)
        {
            // run the benchers before profiling. 
            foreach (IBencher b in benchersToProfile)
            {
                if (b == null)
                {
                    Console.WriteLine("The bencher you are trying to profile hasn't been registered. Can't continue.");
                    return;
                }
                Console.WriteLine(
                    "Running set benchmark for bencher '{0}' before profiling to warm up constructs",
                    b.CreateFrameworkName());
                b.PerformSetBenchmark();
            }

            Console.WriteLine("Attach profiler and press ENTER to continue");
            Console.ReadLine();
            foreach (IBencher b in benchersToProfile)
            {
                if (PerformSetBenchmarks)
                {
                    Console.WriteLine(
                        "Running set benchmark for profile for bencher: {0}. Change tracking: {1}",
                        b.CreateFrameworkName(),
                        b.UsesChangeTracking);
                    b.PerformSetBenchmark();
                }
                if (PerformIndividualBenchMarks)
                {
                    Console.WriteLine(
                        "Running individual fetch benchmark for profile for bencher: {0}. Change tracking: {1}",
                        b.CreateFrameworkName(),
                        b.UsesChangeTracking);
                    b.PerformIndividualBenchMark(KeysForIndividualFetches);
                }
            }
            Console.WriteLine("Done. Grab snapshot and stop profiler. Press ENTER to continue.");
            Console.ReadLine();
        }

        private static void ReportEagerLoadResult(IBencher bencher, BenchResult result)
        {
            Console.WriteLine(
                "[{0}] Number of elements fetched: {1} ({2}).\tFetch took: {3:N2}ms.",
                DateTime.Now.ToString("HH:mm:ss"),
                result.TotalNumberOfRowsFetched,
                string.Join(" + ", result.NumberOfRowsFetchedPerType.Select(kvp => kvp.Value).ToArray()),
                result.FetchTimeInMilliseconds);
        }

        private static void ReportIndividualResult(IBencher bencher, BenchResult result)
        {
            Console.WriteLine(
                "[{0}] Number of elements fetched individually: {1}.\tTotal time: {2:N2}ms.\tTime per element: {3:N2}ms",
                DateTime.Now.ToString("HH:mm:ss"),
                KeysForIndividualFetches.Count,
                result.FetchTimeInMilliseconds,
                result.FetchTimeInMilliseconds / KeysForIndividualFetches.Count);
        }

        /// <summary>
        ///     Reports the resulting statistics (mean/standard deviation) to standard out
        /// </summary>
        /// <param name="autoExit">
        ///     if set to <c>true</c> the method won't wait for ENTER to exit but will exit immediately.
        /// </param>
        private static void ReportResultStatistics(bool autoExit)
        {
            Console.WriteLine("\nResults per framework. Values are given as: 'mean (standard deviation)'");
            Console.WriteLine("==============================================================================");
            int longestNameLength = 0;
            foreach (IBencher bencher in RegisteredBenchers)
            {
                string name = bencher.CreateFrameworkName();
                if (name.Length > longestNameLength)
                {
                    longestNameLength = name.Length;
                }
                bencher.CalculateStatistics();
            }
            if (PerformSetBenchmarks)
            {
                List<IBencher> benchersToList =
                    RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.SetFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine("Non-change tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)",
                            bencher.CreateFrameworkName(),
                            bencher.SetFetchMean,
                            bencher.SetFetchSD,
                            bencher.EnumerationMean,
                            bencher.EnumerationSD);
                    }
                }
                benchersToList =
                    RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.SetFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)",
                            bencher.CreateFrameworkName(),
                            bencher.SetFetchMean,
                            bencher.SetFetchSD,
                            bencher.EnumerationMean,
                            bencher.EnumerationSD);
                    }
                }
            }
            if (PerformIndividualBenchMarks)
            {
                List<IBencher> benchersToList =
                    RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.IndividualFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine(
                        "\nNon-change tracking individual fetches ({0} elements, {1} runs), no caching",
                        IndividualKeysAmount,
                        LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch",
                            bencher.CreateFrameworkName(),
                            bencher.IndividualFetchMean / IndividualKeysAmount,
                            bencher.IndividualFetchSD / IndividualKeysAmount);
                    }
                }
                benchersToList =
                    RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.IndividualFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine(
                        "\nChange tracking individual fetches ({0} elements, {1} runs), no caching",
                        IndividualKeysAmount,
                        LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch",
                            bencher.CreateFrameworkName(),
                            bencher.IndividualFetchMean / IndividualKeysAmount,
                            bencher.IndividualFetchSD / IndividualKeysAmount);
                    }
                }
            }
            if (PerformEagerLoadBenchmarks)
            {
                List<IBencher> benchersToList =
                    RegisteredBenchers.Where(b => b.SupportsEagerLoading && !b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.EagerLoadFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine(
                        "Non-change tracking fetches, eager load fetches, 3-node split graph, 1000 root elements ({0} runs), no caching",
                        LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)",
                            bencher.CreateFrameworkName(),
                            bencher.EagerLoadFetchMean,
                            bencher.EagerLoadFetchSD);
                    }
                }
                benchersToList =
                    RegisteredBenchers.Where(b => b.SupportsEagerLoading && b.UsesChangeTracking && !b.UsesCaching)
                                      .OrderBy(b => b.EagerLoadFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine(
                        "\nChange tracking fetches, eager load fetches, 3-node split graph, 1000 root elements ({0} runs), no caching",
                        LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)",
                            bencher.CreateFrameworkName(),
                            bencher.EagerLoadFetchMean,
                            bencher.EagerLoadFetchSD);
                    }
                }
            }
            if (PerformSetBenchmarks)
            {
                List<IBencher> benchersToList =
                    RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching)
                                      .OrderBy(b => b.SetFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), caching", LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)",
                            bencher.CreateFrameworkName(),
                            bencher.SetFetchMean,
                            bencher.SetFetchSD,
                            bencher.EnumerationMean,
                            bencher.EnumerationSD);
                    }
                }
            }
            if (PerformIndividualBenchMarks)
            {
                List<IBencher> benchersToList =
                    RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching)
                                      .OrderBy(b => b.IndividualFetchMean)
                                      .ToList();
                if (benchersToList.Count > 0)
                {
                    Console.WriteLine(
                        "\nChange tracking individual fetches ({0} elements, {1} runs), caching",
                        IndividualKeysAmount,
                        LoopAmount);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    foreach (IBencher bencher in benchersToList)
                    {
                        Console.WriteLine(
                            "{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch",
                            bencher.CreateFrameworkName(),
                            bencher.IndividualFetchMean / IndividualKeysAmount,
                            bencher.IndividualFetchSD / IndividualKeysAmount);
                    }
                }
            }
            Console.Write("\nComplete.");
            if (autoExit)
            {
                return;
            }
            Console.WriteLine(" Press enter to exit.");
            Console.ReadLine();
        }

        private static void ReportSetResult(BenchResult result)
        {
            Console.WriteLine(
                "[{0}] Number of elements fetched: {1}.\tFetch took: {2:N2}ms.\tEnumerating result took: {3:N2}ms",
                DateTime.Now.ToString("HH:mm:ss"),
                result.TotalNumberOfRowsFetched,
                result.FetchTimeInMilliseconds,
                result.EnumerationTimeInMilliseconds);
        }

        private static void RunBencher(IBencher bencher)
        {
            bencher.ResetResults();
            Console.WriteLine(
                "First one warm-up run of each bench type to initialize constructs. Results will not be collected.");
            BenchResult result = bencher.PerformSetBenchmark(discardResults: true);
            ReportSetResult(result);
            if (bencher.SupportsEagerLoading)
            {
                result = bencher.PerformEagerLoadBenchmark(discardResults: true);
                ReportSetResult(result);
            }
            if (PerformIndividualBenchMarks)
            {
                result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches, discardResults: true);
                ReportIndividualResult(bencher, result);
            }
            Console.WriteLine("\nStarting bench runs...");
            if (PerformSetBenchmarks)
            {
                // set benches
                Console.WriteLine("Set fetches");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < LoopAmount; i++)
                {
                    result = bencher.PerformSetBenchmark();
                    ReportSetResult(result);

                    // avoid having the GC collect in the middle of a run.
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
            if (PerformIndividualBenchMarks)
            {
                // individual benches
                Console.WriteLine("\nSingle element fetches");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < LoopAmount; i++)
                {
                    result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches);
                    ReportIndividualResult(bencher, result);

                    // avoid having the GC collect in the middle of a run.
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
            if (PerformEagerLoadBenchmarks && bencher.SupportsEagerLoading)
            {
                // eager load benches
                Console.WriteLine("\nEager Load fetches");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < LoopAmount; i++)
                {
                    result = bencher.PerformEagerLoadBenchmark();
                    ReportEagerLoadResult(bencher, result);

                    // avoid having the GC collect in the middle of a run.
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
        }

        private static void RunRegisteredBenchers()
        {
            Console.WriteLine("\nStarting benchmarks.");
            Console.WriteLine("====================================================================");

            foreach (IBencher bencher in RegisteredBenchers)
            {
                DisplayBencherInfo(bencher);
                try
                {
                    RunBencher(bencher);
                }
                catch (Exception ex)
                {
                    DisplayException(ex);
                }
            }
        }

        private static void WarmupDB()
        {
            IBencher dbWarmer;
            dbWarmer = new DataTableBencher
                {
                    CommandText = SqlSelectCommandText,
                    ConnectionStringToUse = ConnectionString
                };

            Console.WriteLine("\nWarming up DB, DB client code and CLR");
            Console.WriteLine("====================================================================");
            DisplayBencherInfo(dbWarmer);
            for (int i = 0; i < LoopAmount; i++)
            {
                BenchResult result = dbWarmer.PerformSetBenchmark();
                ReportSetResult(result);
            }
        }

        #endregion
    }
}