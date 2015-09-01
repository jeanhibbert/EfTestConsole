using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CapacityTradeViewMap : EntityTypeConfiguration<CapacityTradeView>
    {
        public CapacityTradeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CapacityProduct, t.StartDateUTC, t.EndDateUTC, t.Volume, t.Unit, t.Counterparty, t.BuySell });

            // Properties
            this.Property(t => t.TradeId)
                .HasMaxLength(20);

            this.Property(t => t.CapacityProduct)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Volume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContractReference)
                .HasMaxLength(100);

            this.Property(t => t.BuySell)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.LineName)
                .HasMaxLength(64);

            this.Property(t => t.CapacityInstrumentType)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("CapacityTradeView", "caprpt");
            this.Property(t => t.TradeId).HasColumnName("TradeId");
            this.Property(t => t.CapacityProduct).HasColumnName("CapacityProduct");
            this.Property(t => t.StartDateUTC).HasColumnName("StartDateUTC");
            this.Property(t => t.EndDateUTC).HasColumnName("EndDateUTC");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.ContractReference).HasColumnName("ContractReference");
            this.Property(t => t.BuySell).HasColumnName("BuySell");
            this.Property(t => t.LineName).HasColumnName("LineName");
            this.Property(t => t.CapacityInstrumentType).HasColumnName("CapacityInstrumentType");
        }
    }
}
