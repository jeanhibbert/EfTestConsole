using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class SecurityRoleMap : EntityTypeConfiguration<SecurityRole>
    {
        public SecurityRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.SecurityRolesId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SecurityRoles");
            this.Property(t => t.SecurityRolesId).HasColumnName("SecurityRolesId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
