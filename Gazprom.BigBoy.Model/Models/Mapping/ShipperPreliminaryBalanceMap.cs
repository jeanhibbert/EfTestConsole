using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class ShipperPreliminaryBalanceMap : EntityTypeConfiguration<ShipperPreliminaryBalance>
    {
        public ShipperPreliminaryBalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.ShipperPreliminaryBalanceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ShipperPreliminaryBalance");
            this.Property(t => t.ShipperPreliminaryBalanceId).HasColumnName("ShipperPreliminaryBalanceId");
            this.Property(t => t.DeliveryDay).HasColumnName("DeliveryDay");
            this.Property(t => t.SumRequestedDailyMetered).HasColumnName("SumRequestedDailyMetered");
            this.Property(t => t.SumRequestedNonDailyMetered).HasColumnName("SumRequestedNonDailyMetered");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.NominationsSystemTypeId).HasColumnName("NominationsSystemTypeId");

            // Relationships
            this.HasRequired(t => t.NominationSystemType)
                .WithMany(t => t.ShipperPreliminaryBalances)
                .HasForeignKey(d => d.NominationsSystemTypeId);

        }
    }
}
