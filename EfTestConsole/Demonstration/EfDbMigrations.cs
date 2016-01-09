namespace EfTestConsole.Demonstration
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;

    using EfTest.AdventureWorks.Data.SqlServer;

    internal class EfDbMigrations
    {
        #region Public Methods and Operators

        public static void GenerateSqlUsingDbMigrator()
        {
            using (var context = new AdventureWorksContext())
            {
                var configuration = new DbMigrationsConfiguration();
                configuration.ContextType = typeof(AdventureWorksContext);
                configuration.TargetDatabase = new DbConnectionInfo(
                    context.Database.Connection.ConnectionString, "System.Data.SqlClient");
                var migrator = new DbMigrator(configuration);

                var scriptor = new MigratorScriptingDecorator(migrator);
                string script = scriptor.ScriptUpdate(
                    "201512301634257_NewTableTestEntity1", "201512301634257_NewTableTestEntity1");
                Console.WriteLine(script);
                Console.ReadKey();
            }
        }

        #endregion
    }
}