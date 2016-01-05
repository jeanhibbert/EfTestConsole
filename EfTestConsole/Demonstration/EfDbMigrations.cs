using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Model.Models;
    using System.Configuration;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;

    class EfDbMigrations
    {
        public static void GenerateSqlUsingDbMigrator()
        {
            using (AdventureWorksContext context = new AdventureWorksContext())
            {
                var configuration = new DbMigrationsConfiguration();
                configuration.ContextType = typeof(AdventureWorksContext);
                configuration.TargetDatabase =
                    new DbConnectionInfo(context.Database.Connection.ConnectionString
                        , "System.Data.SqlClient");
                var migrator = new DbMigrator(configuration);

                var scriptor = new MigratorScriptingDecorator(migrator);
                string script = scriptor.ScriptUpdate("201512301634257_NewTableTestEntity1", "201512301634257_NewTableTestEntity1");
                Console.WriteLine(script);
                Console.ReadKey();
            }
        }
    }
}
