namespace EfTest.AdventurWorks.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableTestEntity1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestEntity1",
                c => new
                    {
                        TestEntity1Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.TestEntity1Id)
                .ForeignKey("Production.Product", t => t.Product_ProductID)
                .Index(t => t.Product_ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestEntity1", "Product_ProductID", "Production.Product");
            DropIndex("dbo.TestEntity1", new[] { "Product_ProductID" });
            DropTable("dbo.TestEntity1");
        }
    }
}
