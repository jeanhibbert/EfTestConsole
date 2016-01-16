namespace EfTestConsole.Benchmarks
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Model.Models;

    /// <summary>
    ///     Specific bencher for Entity Framework, doing normal fetch
    /// </summary>
    public class EntityFrameworkNormalBencher : BencherBase<SalesOrderHeader>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityFrameworkNormalBencher" /> class.
        /// </summary>
        public EntityFrameworkNormalBencher()
            : base(e => e.SalesOrderID, usesChangeTracking: true, usesCaching: false, supportsEagerLoading: true)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Fetches the complete graph using eager loading and returns this as an IEnumerable.
        /// </summary>
        /// <returns>the graph fetched</returns>
        public override IEnumerable<SalesOrderHeader> FetchGraph()
        {
            using (var ctx = new AdventureWorksContext())
            {
                return
                    (from soh in ctx.SalesOrderHeaders
                     where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
                     select soh).Include(x => x.SalesOrderDetails).Include(x => x.Customer).ToList();
            }
        }

        /// <summary>
        ///     Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (var ctx = new AdventureWorksContext())
            {
                return ctx.SalesOrderHeaders.Single(e => e.SalesOrderID == key);
            }
        }

        /// <summary>
        ///     Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (var ctx = new AdventureWorksContext())
            {
                return ctx.SalesOrderHeaders.ToList();
            }
        }

        /// <summary>
        ///     Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
        ///     the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="resultContainer">The result container.</param>
        public override void VerifyGraphElementChildren(SalesOrderHeader parent, BenchResult resultContainer)
        {
            int amount = 0;
            foreach (SalesOrderDetail sod in parent.SalesOrderDetails)
            {
                if (sod.SalesOrderID > 0)
                {
                    amount++;
                }
                else
                {
                    return;
                }
            }
            resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetail), amount);
            if ((parent.Customer == null) || (parent.Customer.CustomerID <= 0))
            {
                return;
            }
            resultContainer.IncNumberOfRowsForType(typeof(Customer), 1);
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
            return this.CreateFrameworkName("Entity Framework v{0} (v{1})", typeof(DbContext));
        }

        #endregion
    }
}