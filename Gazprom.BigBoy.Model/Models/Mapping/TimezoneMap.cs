using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TimezoneMap : EntityTypeConfiguration<Timezone>
    {
        public TimezoneMap()
        {
            // Primary Key
            this.HasKey(t => t.TimezoneId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Timezone", "refdata");
            this.Property(t => t.TimezoneId).HasColumnName("TimezoneId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.GasDayLocalStartHour).HasColumnName("GasDayLocalStartHour");
            this.Property(t => t.StartUtc).HasColumnName("StartUtc");
            this.Property(t => t.EndUtc).HasColumnName("EndUtc");
        }
    }
}
