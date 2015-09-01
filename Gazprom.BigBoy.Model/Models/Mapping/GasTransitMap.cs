using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTransitMap : EntityTypeConfiguration<GasTransit>
    {
        public GasTransitMap()
        {
            // Primary Key
            this.HasKey(t => t.GasTransitId);

            // Properties
            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("GasTransit");
            this.Property(t => t.GasTransitId).HasColumnName("GasTransitId");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.StartDateUTC).HasColumnName("StartDateUTC");
            this.Property(t => t.EndDateUTC).HasColumnName("EndDateUTC");
            this.Property(t => t.FromInternalShippingId).HasColumnName("FromInternalShippingId");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.ToInternalShippingId).HasColumnName("ToInternalShippingId");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.TransitRouteLegId).HasColumnName("TransitRouteLegId");

            // Relationships
            this.HasRequired(t => t.GasPipeline)
                .WithMany(t => t.GasTransits)
                .HasForeignKey(d => d.GasPipelineId);
            this.HasOptional(t => t.InternalShipping)
                .WithMany(t => t.GasTransits)
                .HasForeignKey(d => d.FromInternalShippingId);
            this.HasOptional(t => t.InternalShipping1)
                .WithMany(t => t.GasTransits1)
                .HasForeignKey(d => d.ToInternalShippingId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.GasTransits)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
