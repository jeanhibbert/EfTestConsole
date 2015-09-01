using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TradeCancellationViewMap : EntityTypeConfiguration<TradeCancellationView>
    {
        public TradeCancellationViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TradeCancellationId, t.StartDateUtc, t.EndDateUtc, t.ActionIndicator, t.Counterparty, t.GasLocationId });

            // Properties
            this.Property(t => t.TradeCancellationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ActionIndicator)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TradeCancellationView", "caprpt");
            this.Property(t => t.TradeCancellationId).HasColumnName("TradeCancellationId");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.EndDateUtc).HasColumnName("EndDateUtc");
            this.Property(t => t.ActionIndicator).HasColumnName("ActionIndicator");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
        }
    }
}
