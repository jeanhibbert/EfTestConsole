using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.NTLogin)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(64);

            this.Property(t => t.MobileNumber)
                .HasMaxLength(32);

            this.Property(t => t.WindowTitleCustomisation)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.NTLogin).HasColumnName("NTLogin");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Disabled).HasColumnName("Disabled");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.MobileNumber).HasColumnName("MobileNumber");
            this.Property(t => t.WindowTitleCustomisation).HasColumnName("WindowTitleCustomisation");
        }
    }
}
