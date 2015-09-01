using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTradeDetailEndurMap : EntityTypeConfiguration<GasTradeDetailEndur>
    {
        public GasTradeDetailEndurMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TradeId, t.Location });

            // Properties
            this.Property(t => t.TradeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstrumentType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.TranStatus)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Trader)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BuySell)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.VolumeType)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.DenominationPriceUnitName)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.PriceType)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.ServiceType)
                .HasMaxLength(64);

            this.Property(t => t.LineName)
                .HasMaxLength(64);

            this.Property(t => t.WthInj)
                .HasMaxLength(1);

            this.Property(t => t.UpdatedByEngine)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ContractRef)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GasTradeDetailEndur");
            this.Property(t => t.TradeId).HasColumnName("TradeId");
            this.Property(t => t.InstrumentType).HasColumnName("InstrumentType");
            this.Property(t => t.TranNum).HasColumnName("TranNum");
            this.Property(t => t.InstrumentNum).HasColumnName("InstrumentNum");
            this.Property(t => t.VersionNumber).HasColumnName("VersionNumber");
            this.Property(t => t.TranStatus).HasColumnName("TranStatus");
            this.Property(t => t.Trader).HasColumnName("Trader");
            this.Property(t => t.TradeDate).HasColumnName("TradeDate");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.BuySell).HasColumnName("BuySell");
            this.Property(t => t.StartDateUTC).HasColumnName("StartDateUTC");
            this.Property(t => t.EndDateUTC).HasColumnName("EndDateUTC");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.VolumeType).HasColumnName("VolumeType");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Spread).HasColumnName("Spread");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.DenominationPriceUnitName).HasColumnName("DenominationPriceUnitName");
            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.ServiceType).HasColumnName("ServiceType");
            this.Property(t => t.LineName).HasColumnName("LineName");
            this.Property(t => t.WthInj).HasColumnName("WthInj");
            this.Property(t => t.UpdatedByEngine).HasColumnName("UpdatedByEngine");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.ContractRef).HasColumnName("ContractRef");
        }
    }
}
