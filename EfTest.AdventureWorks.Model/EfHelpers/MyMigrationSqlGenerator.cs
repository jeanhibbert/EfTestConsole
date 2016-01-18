namespace EfTest.AdventurWorks.Model.EfHelpers
{
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;
    using System.Linq;

    public class MyMigrationSqlGenerator : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(MigrationOperation migrationOperation)
        {
            var op = migrationOperation as CreateFullTextIndexOperation;
            if (op != null)
            {
                using (var writer = Writer())
                {
                    writer.WriteLine("IF(NOT EXISTS(SELECT * FROM SYS.fulltext_catalogs WHERE is_default = 1))");
                    writer.WriteLine("BEGIN");
                    writer.WriteLine("    CREATE FULLTEXT CATALOG DefaultFullTextCatalog AS DEFAULT");
                    writer.WriteLine("END");

                    writer.WriteLine();

                    writer.WriteLine("CREATE FULLTEXT INDEX ON {0} ({1})", this.Name(op.Table), string.Join(", ", op.Columns.Select(c => this.Quote(c))));
                    writer.WriteLine("KEY INDEX {0}", this.Quote(op.Index));
                    writer.WriteLine("WITH CHANGE_TRACKING AUTO");

                    this.Statement(writer.InnerWriter.ToString(), suppressTransaction: true);
                } 
            }
            else
            {
                base.Generate(migrationOperation);
            }
        }
    }
}