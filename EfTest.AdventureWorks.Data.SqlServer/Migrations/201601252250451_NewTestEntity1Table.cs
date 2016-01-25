namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class NewTestEntity1Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestEntity1",
                c => new
                    {
                        TestEntity1Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.TestEntity1Id)
                .Index(t => t.Name, unique: true);
            
            AddColumn("Person.Contact", "TestEntity1_TestEntity1Id", c => c.Int());
            CreateIndex("Person.Contact", "TestEntity1_TestEntity1Id");
            AddForeignKey("Person.Contact", "TestEntity1_TestEntity1Id", "dbo.TestEntity1", "TestEntity1Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Person.Contact", "TestEntity1_TestEntity1Id", "dbo.TestEntity1");
            DropIndex("dbo.TestEntity1", new[] { "Name" });
            DropIndex("Person.Contact", new[] { "TestEntity1_TestEntity1Id" });
            DropColumn("Person.Contact", "TestEntity1_TestEntity1Id");
            AlterTableAnnotations(
                "Person.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        NameStyle = c.Boolean(nullable: false),
                        Title = c.String(maxLength: 8),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Suffix = c.String(maxLength: 10),
                        EmailAddress = c.String(maxLength: 50),
                        EmailPromotion = c.Int(nullable: false),
                        Phone = c.String(maxLength: 25),
                        PasswordHash = c.String(nullable: false, maxLength: 128),
                        PasswordSalt = c.String(nullable: false, maxLength: 10),
                        AdditionalContactInfo = c.String(),
                        rowguid = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        TestEntity1_TestEntity1Id = c.Int(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "SoftDeleteColumnName",
                        new AnnotationValues(oldValue: null, newValue: "IsDeleted")
                    },
                });
            
            DropTable("dbo.TestEntity1");
        }
    }
}
