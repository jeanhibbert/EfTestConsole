namespace EfTest.AdventureWorks.Data.SqlServer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class ContactIsDeleted : DbMigration
    {
        public override void Up()
        {
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
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "SoftDeleteColumnName",
                        new AnnotationValues(oldValue: null, newValue: "IsDeleted")
                    },
                });
            
            AddColumn("Person.Contact", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Person.Contact", "IsDeleted");
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
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "SoftDeleteColumnName",
                        new AnnotationValues(oldValue: "IsDeleted", newValue: null)
                    },
                });
            
        }
    }
}
