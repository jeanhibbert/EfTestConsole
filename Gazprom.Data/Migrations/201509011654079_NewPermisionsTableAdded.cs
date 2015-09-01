namespace Gazprom.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPermisionsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PermissionId);
            
            CreateTable(
                "dbo.UserRolePermissions",
                c => new
                    {
                        UserRole_UserRolesId = c.Int(nullable: false),
                        Permission_PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserRole_UserRolesId, t.Permission_PermissionId })
                .ForeignKey("dbo.UserRoles", t => t.UserRole_UserRolesId, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.Permission_PermissionId, cascadeDelete: true)
                .Index(t => t.UserRole_UserRolesId)
                .Index(t => t.Permission_PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRolePermissions", "Permission_PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.UserRolePermissions", "UserRole_UserRolesId", "dbo.UserRoles");
            DropIndex("dbo.UserRolePermissions", new[] { "Permission_PermissionId" });
            DropIndex("dbo.UserRolePermissions", new[] { "UserRole_UserRolesId" });
            DropTable("dbo.UserRolePermissions");
            DropTable("dbo.Permissions");
        }
    }
}
