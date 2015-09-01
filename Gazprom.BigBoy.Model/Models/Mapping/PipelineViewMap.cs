using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class PipelineViewMap : EntityTypeConfiguration<PipelineView>
    {
        public PipelineViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasPipelineId, t.FromLocationId, t.ToLocationId, t.CheckExit, t.CheckEntry, t.IsExternal, t.FuelGas, t.UpliftFactor, t.RedeliveryTransitItem, t.IsVirtual });

            // Properties
            this.Property(t => t.GasPipelineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(64);

            this.Property(t => t.FromLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromLocationExitLineName)
                .HasMaxLength(100);

            this.Property(t => t.ToLocationEntryLineName)
                .HasMaxLength(100);

            this.Property(t => t.FromLocationDisplayName)
                .HasMaxLength(24);

            this.Property(t => t.ToLocationDisplayName)
                .HasMaxLength(24);

            this.Property(t => t.FuelGas)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpliftFactor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromInternalShipperCode)
                .HasMaxLength(50);

            this.Property(t => t.ToInternalShipperCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PipelineView", "caprpt");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FromLocationId).HasColumnName("FromLocationId");
            this.Property(t => t.ToLocationId).HasColumnName("ToLocationId");
            this.Property(t => t.FromLocationExitLineName).HasColumnName("FromLocationExitLineName");
            this.Property(t => t.ToLocationEntryLineName).HasColumnName("ToLocationEntryLineName");
            this.Property(t => t.CheckExit).HasColumnName("CheckExit");
            this.Property(t => t.CheckEntry).HasColumnName("CheckEntry");
            this.Property(t => t.IsExternal).HasColumnName("IsExternal");
            this.Property(t => t.FromLocationDisplayName).HasColumnName("FromLocationDisplayName");
            this.Property(t => t.ToLocationDisplayName).HasColumnName("ToLocationDisplayName");
            this.Property(t => t.FuelGas).HasColumnName("FuelGas");
            this.Property(t => t.UpliftFactor).HasColumnName("UpliftFactor");
            this.Property(t => t.FromInternalShippingId).HasColumnName("FromInternalShippingId");
            this.Property(t => t.ToInternalShippingId).HasColumnName("ToInternalShippingId");
            this.Property(t => t.RedeliveryTransitItem).HasColumnName("RedeliveryTransitItem");
            this.Property(t => t.IsVirtual).HasColumnName("IsVirtual");
            this.Property(t => t.FromInternalShipperCode).HasColumnName("FromInternalShipperCode");
            this.Property(t => t.ToInternalShipperCode).HasColumnName("ToInternalShipperCode");
            this.Property(t => t.Hide).HasColumnName("Hide");
        }
    }
}
