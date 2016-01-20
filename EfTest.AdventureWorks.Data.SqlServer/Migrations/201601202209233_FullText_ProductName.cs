namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    using EfTest.AdventurWorks.Model.EfHelpers;

    public partial class FullText_ProductName : DbMigration
    {
        public override void Up()
        {
            this.CreateFullTextIndex(
               "Production.Product",
               "PK_Product_ProductID",
               new[] { "Name" });
        }
        
        public override void Down()
        {
        }
    }
}
