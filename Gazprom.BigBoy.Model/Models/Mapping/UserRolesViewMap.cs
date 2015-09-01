using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UserRolesViewMap : EntityTypeConfiguration<UserRolesView>
    {
        public UserRolesViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Rolename, t.UserLogin, t.UserRoleId, t.Disabled });

            // Properties
            this.Property(t => t.Rolename)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserLogin)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.UserRoleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserRolesView", "caprpt");
            this.Property(t => t.Rolename).HasColumnName("Rolename");
            this.Property(t => t.UserLogin).HasColumnName("UserLogin");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleId");
            this.Property(t => t.Disabled).HasColumnName("Disabled");
        }
    }
}
