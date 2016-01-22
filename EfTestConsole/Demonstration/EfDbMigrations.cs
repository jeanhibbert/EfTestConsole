namespace EfTestConsole.Demonstration
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.Migrations;

    internal class EfDbMigrations
    {
        #region Public Methods and Operators

        public static void GenerateSqlUsingDbMigrator()
        {
            using (var context = new AdventureWorksContext())
            {
                var configuration = new Configuration
                    {
                        ContextType = typeof(AdventureWorksContext),
                        TargetDatabase =
                            new DbConnectionInfo(context.Database.Connection.ConnectionString, "System.Data.SqlClient")
                    };
                var migrator = new DbMigrator(configuration);
                var migrations = migrator.GetDatabaseMigrations();
                if (migrations.Any())
                {
                    var scriptor = new MigratorScriptingDecorator(migrator);
                    string script = scriptor.ScriptUpdate(null, migrations.Last());
                    if (!String.IsNullOrEmpty(script))
                    {
                        Console.WriteLine(script);
                        //context.Database.ExecuteSqlCommand(script);
                    }
                }                
                
                Console.ReadKey();
            }
        }

        #endregion
    }
}