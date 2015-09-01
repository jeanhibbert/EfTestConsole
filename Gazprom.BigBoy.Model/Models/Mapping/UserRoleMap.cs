using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRolesId);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("UserRoles");
            this.Property(t => t.UserRolesId).HasColumnName("UserRolesId");
            this.Property(t => t.User).HasColumnName("User");
            this.Property(t => t.Role).HasColumnName("Role");
            this.Property(t => t.Comment).HasColumnName("Comment");

            // Relationships
            this.HasRequired(t => t.Role1)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.Role);
            this.HasRequired(t => t.User1)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.User);

        }
    }
}
