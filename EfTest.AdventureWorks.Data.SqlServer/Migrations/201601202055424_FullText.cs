namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    using EfTest.AdventurWorks.Model.EfHelpers;

    public partial class FullText : DbMigration
    {
        public override void Up()
        {
            this.CreateFullTextIndex(
               "Production.ProductDescription",
               "PK_ProductDescription_ProductDescriptionID",
               new[] { "Description" });
        }
        
        public override void Down()
        {
        }
    }
}
