using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasPipelineMap : EntityTypeConfiguration<GasPipeline>
    {
        public GasPipelineMap()
        {
            // Primary Key
            this.HasKey(t => t.GasPipelineId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.FromLocationExitLineName)
                .HasMaxLength(100);

            this.Property(t => t.ToLocationEntryLineName)
                .HasMaxLength(100);

            this.Property(t => t.FromLocationShipperCode)
                .HasMaxLength(32);

            this.Property(t => t.ToLocationShipperCode)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("GasPipeline");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FromLocationId).HasColumnName("FromLocationId");
            this.Property(t => t.ToLocationId).HasColumnName("ToLocationId");
            this.Property(t => t.IsVirtual).HasColumnName("IsVirtual");
            this.Property(t => t.UpliftFactor).HasColumnName("UpliftFactor");
            this.Property(t => t.FuelGas).HasColumnName("FuelGas");
            this.Property(t => t.FromLocationExitLineName).HasColumnName("FromLocationExitLineName");
            this.Property(t => t.ToLocationEntryLineName).HasColumnName("ToLocationEntryLineName");
            this.Property(t => t.CheckExit).HasColumnName("CheckExit");
            this.Property(t => t.CheckEntry).HasColumnName("CheckEntry");
            this.Property(t => t.FromLocationShipperCode).HasColumnName("FromLocationShipperCode");
            this.Property(t => t.ToLocationShipperCode).HasColumnName("ToLocationShipperCode");
            this.Property(t => t.ApplyPipelineCapacity).HasColumnName("ApplyPipelineCapacity");
            this.Property(t => t.IsExternal).HasColumnName("IsExternal");
            this.Property(t => t.RedeliveryTransitItem).HasColumnName("RedeliveryTransitItem");
            this.Property(t => t.FromInternalShippingId).HasColumnName("FromInternalShippingId");
            this.Property(t => t.ToInternalShippingId).HasColumnName("ToInternalShippingId");
            this.Property(t => t.Hide).HasColumnName("Hide");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasPipelines)
                .HasForeignKey(d => d.FromLocationId);
            this.HasRequired(t => t.GasLocation1)
                .WithMany(t => t.GasPipelines1)
                .HasForeignKey(d => d.ToLocationId);
            this.HasOptional(t => t.InternalShipping)
                .WithMany(t => t.GasPipelines)
                .HasForeignKey(d => d.FromInternalShippingId);
            this.HasOptional(t => t.InternalShipping1)
                .WithMany(t => t.GasPipelines1)
                .HasForeignKey(d => d.ToInternalShippingId);

        }
    }
}
