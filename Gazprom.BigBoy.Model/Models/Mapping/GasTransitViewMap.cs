using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTransitViewMap : EntityTypeConfiguration<GasTransitView>
    {
        public GasTransitViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasTransitId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.CheckExit, t.GasPipelineId, t.GasPipelineName, t.GasLocationIdFrom, t.CheckEntry, t.GasLocationIdTo, t.FromInternalShippingId, t.ToInternalShippingId });

            // Properties
            this.Property(t => t.GasTransitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Volume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasPipelineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasPipelineName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.GasLocationIdFrom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasLocationIdTo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContractReferenceFrom)
                .HasMaxLength(50);

            this.Property(t => t.ContractReferenceTo)
                .HasMaxLength(50);

            this.Property(t => t.CapacityInstrumentTypeTo)
                .HasMaxLength(32);

            this.Property(t => t.CapacityInstrumentTypeFrom)
                .HasMaxLength(32);

            this.Property(t => t.TransitRouteLegFromLineName)
                .HasMaxLength(64);

            this.Property(t => t.TransitRouteLegToLineName)
                .HasMaxLength(64);

            this.Property(t => t.TransitRouteLegFromCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.TransitRouteLegToCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.FromInternalShippingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToInternalShippingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GasTransitView", "caprpt");
            this.Property(t => t.GasTransitId).HasColumnName("GasTransitId");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.EndDateUtc).HasColumnName("EndDateUtc");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.CheckExit).HasColumnName("CheckExit");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.GasPipelineName).HasColumnName("GasPipelineName");
            this.Property(t => t.GasLocationIdFrom).HasColumnName("GasLocationIdFrom");
            this.Property(t => t.CheckEntry).HasColumnName("CheckEntry");
            this.Property(t => t.GasLocationIdTo).HasColumnName("GasLocationIdTo");
            this.Property(t => t.ContractReferenceFrom).HasColumnName("ContractReferenceFrom");
            this.Property(t => t.ContractReferenceTo).HasColumnName("ContractReferenceTo");
            this.Property(t => t.CapacityInstrumentTypeTo).HasColumnName("CapacityInstrumentTypeTo");
            this.Property(t => t.CapacityInstrumentTypeFrom).HasColumnName("CapacityInstrumentTypeFrom");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.TransitRouteLegId).HasColumnName("TransitRouteLegId");
            this.Property(t => t.TransitRouteLegFromLineName).HasColumnName("TransitRouteLegFromLineName");
            this.Property(t => t.TransitRouteLegToLineName).HasColumnName("TransitRouteLegToLineName");
            this.Property(t => t.TransitRouteLegFromCapacityInstrumentType).HasColumnName("TransitRouteLegFromCapacityInstrumentType");
            this.Property(t => t.TransitRouteLegToCapacityInstrumentType).HasColumnName("TransitRouteLegToCapacityInstrumentType");
            this.Property(t => t.FromInternalShippingId).HasColumnName("FromInternalShippingId");
            this.Property(t => t.ToInternalShippingId).HasColumnName("ToInternalShippingId");
        }
    }
}
