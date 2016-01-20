namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;

    using EfTest.AdventurWorks.Model.EfHelpers;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<AdventureWorksContext>
    {
        #region Constructors and Destructors

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;

            this.SetSqlGenerator(SqlProviderServices.ProviderInvariantName, new MyMigrationSqlGenerator());
        }

        #endregion

        #region Methods

        protected override void Seed(AdventureWorksContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        #endregion
    }
}