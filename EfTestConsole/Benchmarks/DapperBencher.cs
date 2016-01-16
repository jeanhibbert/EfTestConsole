namespace EfTestConsole.Benchmarks
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using Dapper;

    using EfTest.AdventureWorks.Model.Models;

    using EfTestConsole.Demonstration;

    /// <summary>
    ///     Specific bencher for Dapper , doing no-change tracking fetch
    /// </summary>
    public class DapperBencher : BencherBase<SalesOrderHeader>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DapperBencher" /> class.
        /// </summary>
        public DapperBencher()
            : base(e => e.SalesOrderID, usesChangeTracking: false, usesCaching: false)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the command text.
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        ///     Gets or sets the connection string to use
        /// </summary>
        public string ConnectionStringToUse { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override SalesOrderHeader FetchIndividual(int key)
        {
            SalesOrderHeader header;
            using (var con = new SqlConnection(this.ConnectionStringToUse))
            {
                con.Open();
                header =
                    con.Query<SalesOrderHeader>(
                        this.CommandText + " WHERE SalesOrderID=@p", new { p = key }, buffered: false).FirstOrDefault();
                con.Close();
            }
            return header;
        }

        /// <summary>
        ///     Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            List<SalesOrderHeader> headers;
            using (var con = new SqlConnection(this.ConnectionStringToUse))
            {
                con.Open();
                headers = con.Query<SalesOrderHeader>(this.CommandText).AsList();
                con.Close();
            }
            return headers;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        ///     specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return "Dapper v" + EfBenchmarks.GetVersion(typeof(SqlMapper));
        }

        #endregion
    }
}