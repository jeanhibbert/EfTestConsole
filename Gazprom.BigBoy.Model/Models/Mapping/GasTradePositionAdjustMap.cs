using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTradePositionAdjustMap : EntityTypeConfiguration<GasTradePositionAdjust>
    {
        public GasTradePositionAdjustMap()
        {
            // Primary Key
            this.HasKey(t => t.GasTradePositionAdjustId);

            // Properties
            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("GasTradePositionAdjust");
            this.Property(t => t.GasTradePositionAdjustId).HasColumnName("GasTradePositionAdjustId");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.InternalShippingId).HasColumnName("InternalShippingId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.StartDateUTC).HasColumnName("StartDateUTC");
            this.Property(t => t.EndDateUTC).HasColumnName("EndDateUTC");
            this.Property(t => t.TradeDate).HasColumnName("TradeDate");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.Cancel).HasColumnName("Cancel");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasTradePositionAdjusts)
                .HasForeignKey(d => d.GasLocationId);
            this.HasOptional(t => t.InternalShipping)
                .WithMany(t => t.GasTradePositionAdjusts)
                .HasForeignKey(d => d.InternalShippingId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.GasTradePositionAdjusts)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
