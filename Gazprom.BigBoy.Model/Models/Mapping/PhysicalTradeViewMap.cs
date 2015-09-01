using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class PhysicalTradeViewMap : EntityTypeConfiguration<PhysicalTradeView>
    {
        public PhysicalTradeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TradeId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.Unit, t.BuySell, t.Counterparty, t.EndurLocation });

            // Properties
            this.Property(t => t.TradeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Volume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContractReference)
                .HasMaxLength(100);

            this.Property(t => t.BuySell)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EndurLocation)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CapacityInstrumentType)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("PhysicalTradeView", "caprpt");
            this.Property(t => t.TradeId).HasColumnName("TradeId");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.EndDateUtc).HasColumnName("EndDateUtc");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.ContractReference).HasColumnName("ContractReference");
            this.Property(t => t.BuySell).HasColumnName("BuySell");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.EndurLocation).HasColumnName("EndurLocation");
            this.Property(t => t.CapacityInstrumentType).HasColumnName("CapacityInstrumentType");
        }
    }
}
