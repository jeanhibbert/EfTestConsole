using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CapacityRouteLegMap : EntityTypeConfiguration<CapacityRouteLeg>
    {
        public CapacityRouteLegMap()
        {
            // Primary Key
            this.HasKey(t => t.CapacityRouteLegId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CapacityRouteLegs");
            this.Property(t => t.CapacityRouteLegId).HasColumnName("CapacityRouteLegId");
            this.Property(t => t.RouteId).HasColumnName("RouteId");
            this.Property(t => t.LegNumber).HasColumnName("LegNumber");
            this.Property(t => t.InstrumentTypeId).HasColumnName("InstrumentTypeId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");

            // Relationships
            this.HasRequired(t => t.CapacityTradeMultiLegRoute)
                .WithMany(t => t.CapacityRouteLegs)
                .HasForeignKey(d => d.RouteId);
            this.HasRequired(t => t.EndurInstrumentType)
                .WithMany(t => t.CapacityRouteLegs)
                .HasForeignKey(d => d.InstrumentTypeId);
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.CapacityRouteLegs)
                .HasForeignKey(d => d.GasLocationId);
            this.HasRequired(t => t.GasPipeline)
                .WithMany(t => t.CapacityRouteLegs)
                .HasForeignKey(d => d.GasPipelineId);

        }
    }
}
