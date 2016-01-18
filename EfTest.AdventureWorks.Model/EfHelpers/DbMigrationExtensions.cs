namespace EfTest.AdventurWorks.Model.EfHelpers
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;

    public static class DbMigrationExtensions
    {
        public static void CreateFullTextIndex(
            this DbMigration migration, 
            string table, 
            string index, 
            string[] columns)
        {
            var op = new CreateFullTextIndexOperation
            {
                Table = table,
                Index = index,
                Columns = columns
            };

            ((IDbMigration)migration).AddOperation(op);
        }
    }
}