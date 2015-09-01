using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CapacityDayCheckMap : EntityTypeConfiguration<CapacityDayCheck>
    {
        public CapacityDayCheckMap()
        {
            // Primary Key
            this.HasKey(t => t.CapacityDayCheckId);

            // Properties
            this.Property(t => t.DayDescription)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("CapacityDayCheck");
            this.Property(t => t.CapacityDayCheckId).HasColumnName("CapacityDayCheckId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.DayDescription).HasColumnName("DayDescription");
            this.Property(t => t.Offset).HasColumnName("Offset");

            // Relationships
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.CapacityDayChecks)
                .HasForeignKey(d => d.GasNetworkId);

        }
    }
}
