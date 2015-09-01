using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class PositionAdjustViewMap : EntityTypeConfiguration<PositionAdjustView>
    {
        public PositionAdjustViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasTradePositionAdjustId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.Counterparty, t.Unit, t.GasLocationId });

            // Properties
            this.Property(t => t.GasTradePositionAdjustId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Volume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ContractReference)
                .HasMaxLength(50);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CapacityInstrumentType)
                .HasMaxLength(32);

            this.Property(t => t.InternalShippingCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PositionAdjustView", "caprpt");
            this.Property(t => t.GasTradePositionAdjustId).HasColumnName("GasTradePositionAdjustId");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.EndDateUtc).HasColumnName("EndDateUtc");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.ProfileStartDateUtc).HasColumnName("ProfileStartDateUtc");
            this.Property(t => t.ProfileEndDateUtc).HasColumnName("ProfileEndDateUtc");
            this.Property(t => t.ProfileVolume).HasColumnName("ProfileVolume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ContractReference).HasColumnName("ContractReference");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.CapacityInstrumentType).HasColumnName("CapacityInstrumentType");
            this.Property(t => t.InternalShippingId).HasColumnName("InternalShippingId");
            this.Property(t => t.InternalShippingCode).HasColumnName("InternalShippingCode");
        }
    }
}
