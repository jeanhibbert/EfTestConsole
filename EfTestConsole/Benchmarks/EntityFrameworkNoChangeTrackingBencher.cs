namespace EfTestConsole.Benchmarks
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Model.Models;

    /// <summary>
    ///     Specific bencher for Entity Framework, doing no change tracking fetch
    /// </summary>
    public class EntityFrameworkNoChangeTrackingBencher : BencherBase<SalesOrderHeader>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityFrameworkNoChangeTrackingBencher" /> class.
        /// </summary>
        public EntityFrameworkNoChangeTrackingBencher()
            : base(e => e.SalesOrderID, usesChangeTracking: false, usesCaching: false)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (var ctx = new AdventureWorksContext())
            {
                return ctx.SalesOrderHeaders.AsNoTracking().Single(e => e.SalesOrderID == key);
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
                return ctx.SalesOrderHeaders.AsNoTracking().ToList();
            }
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