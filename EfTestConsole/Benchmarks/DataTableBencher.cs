namespace EfTestConsole.Benchmarks
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    /// <summary>
    ///     Specific bencher for the DataTable filling DbDataAdapter materializer, doing change tracking fetch
    /// </summary>
    public class DataTableBencher : BencherBase<DataRow>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataTableBencher" /> class.
        /// </summary>
        public DataTableBencher()
            : base(r => Convert.ToInt32(r["SalesOrderId"]), usesChangeTracking: true, usesCaching: false)
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
        public override DataRow FetchIndividual(int key)
        {
            var toExecute = new SqlCommand(this.CommandText + " WHERE SalesOrderId=@p");
            toExecute.Parameters.Add(new SqlParameter("@p", key));

            IEnumerable<DataRow> results = this.MaterializeSet(toExecute);
            return results.FirstOrDefault();
        }

        /// <summary>
        ///     Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<DataRow> FetchSet()
        {
            return this.MaterializeSet(new SqlCommand(this.CommandText));
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
            return "DataTable, using DbDataAdapter";
        }

        /// <summary>
        ///     Materializes the set which is returned by the query specified
        /// </summary>
        /// <param name="toExecute">To execute.</param>
        /// <returns>
        ///     set of elements materialized from the set returned by the query specified
        /// </returns>
        private IEnumerable<DataRow> MaterializeSet(SqlCommand toExecute)
        {
            var headers = new DataTable();
            using (var con = new SqlConnection(this.ConnectionStringToUse))
            {
                toExecute.Connection = con;
                var adapter = new SqlDataAdapter(toExecute);
                adapter.Fill(headers);
            }
            return headers.AsEnumerable();
        }

        #endregion
    }
}