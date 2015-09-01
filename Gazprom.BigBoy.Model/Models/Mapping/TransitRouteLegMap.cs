using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TransitRouteLegMap : EntityTypeConfiguration<TransitRouteLeg>
    {
        public TransitRouteLegMap()
        {
            // Primary Key
            this.HasKey(t => t.TransitRouteLegId);

            // Properties
            this.Property(t => t.FromCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.ToCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.FromLineName)
                .HasMaxLength(64);

            this.Property(t => t.ToLineName)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("TransitRouteLeg");
            this.Property(t => t.TransitRouteLegId).HasColumnName("TransitRouteLegId");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.LegNumber).HasColumnName("LegNumber");
            this.Property(t => t.FromShipperId).HasColumnName("FromShipperId");
            this.Property(t => t.ToShipperId).HasColumnName("ToShipperId");
            this.Property(t => t.FromCapacityInstrumentType).HasColumnName("FromCapacityInstrumentType");
            this.Property(t => t.ToCapacityInstrumentType).HasColumnName("ToCapacityInstrumentType");
            this.Property(t => t.FromLineName).HasColumnName("FromLineName");
            this.Property(t => t.ToLineName).HasColumnName("ToLineName");
            this.Property(t => t.PipelineId).HasColumnName("PipelineId");

            // Relationships
            this.HasOptional(t => t.GasPipeline)
                .WithMany(t => t.TransitRouteLegs)
                .HasForeignKey(d => d.PipelineId);
            this.HasOptional(t => t.InternalShipping)
                .WithMany(t => t.TransitRouteLegs)
                .HasForeignKey(d => d.FromShipperId);
            this.HasOptional(t => t.InternalShipping1)
                .WithMany(t => t.TransitRouteLegs1)
                .HasForeignKey(d => d.ToShipperId);
            this.HasRequired(t => t.TransitRoute)
                .WithMany(t => t.TransitRouteLegs)
                .HasForeignKey(d => d.TransitRouteId);

        }
    }
}
