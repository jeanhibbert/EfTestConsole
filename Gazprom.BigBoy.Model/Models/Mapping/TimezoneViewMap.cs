using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TimezoneViewMap : EntityTypeConfiguration<TimezoneView>
    {
        public TimezoneViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TimezoneId, t.Name, t.Code });

            // Properties
            this.Property(t => t.TimezoneId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("TimezoneView", "caprpt");
            this.Property(t => t.TimezoneId).HasColumnName("TimezoneId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
        }
    }
}
