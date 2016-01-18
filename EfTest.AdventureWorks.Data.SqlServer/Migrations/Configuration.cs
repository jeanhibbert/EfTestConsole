namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;
    using System.Linq;

    using EfTest.AdventurWorks.Model.EfHelpers;

    internal sealed class Configuration : DbMigrationsConfiguration<EfTest.AdventureWorks.Data.SqlServer.EntityFramework.AdventureWorksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            SetSqlGenerator(
                SqlProviderServices.ProviderInvariantName,
                new MyMigrationSqlGenerator());
        }

        protected override void Seed(EfTest.AdventureWorks.Data.SqlServer.EntityFramework.AdventureWorksContext context)
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
    }
}
