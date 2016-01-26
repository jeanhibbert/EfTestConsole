namespace EfTestConsole
{
    using EfTestConsole.Demonstration;
    using HibernatingRhinos.Profiler.Appender.EntityFramework;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            EntityFrameworkProfiler.Initialize();

            // ------------------------ Lazy vs Deep load EF queries ----------------------------------//
            //EfQueryGeneration.ShowSelect();
            //EfCaching.DemonstrateCaching();
            //EfDbMigrations.GenerateSqlUsingDbMigrator();
            //EfRawSqlQueries.EfVsMassiveVsDapperTest();
            //EfBenchmarks.RunBenchmarks();
            //EfProductRepositoryTest.TestProductRepository();
            //EfDbContextScope.EfDbContextScopeTest();
            MassiveSandbox.MassiveApiTests();

        }

        #endregion
    }
}