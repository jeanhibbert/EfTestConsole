using Gazprom.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Helpers
{
    public static class SqlScriptGenerator
    {
        public static void GenerateScript()
        {
            DbMigrator efMigrator = new DbMigrator(new DbMigrationsConfiguration());
            var pendingMigrations = efMigrator.GetLocalMigrations().ToList();
            pendingMigrations.Insert(0, "0");
            foreach (var migration in pendingMigrations.Zip(pendingMigrations.Skip(1), Tuple.Create))
            {
                var sql = new MigratorScriptingDecorator(efMigrator).ScriptUpdate(migration.Item1, migration.Item2); // <-- problem here, the efMigrator is reused several times
                Console.WriteLine("Migration from " + (migration.Item1 ?? "<null> ") + " to " + (migration.Item2 ?? "<null> "));
                Console.WriteLine(sql);
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
