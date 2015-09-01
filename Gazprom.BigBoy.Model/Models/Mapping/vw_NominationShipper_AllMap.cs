using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class vw_NominationShipper_AllMap : EntityTypeConfiguration<vw_NominationShipper_All>
    {
        public vw_NominationShipper_AllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NomiantionShipperId, t.ShipperCode, t.DeliveryDate, t.Status, t.GasLocationId, t.LocationCode, t.NominationId, t.version, t.IsLatest, t.IsBuy });

            // Properties
            this.Property(t => t.NomiantionShipperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CounterpartyName)
                .HasMaxLength(200);

            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NominationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_NominationShipper_All");
            this.Property(t => t.NomiantionShipperId).HasColumnName("NomiantionShipperId");
            this.Property(t => t.CounterpartyName).HasColumnName("CounterpartyName");
            this.Property(t => t.ShipperId).HasColumnName("ShipperId");
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode");
            this.Property(t => t.InternalShippingId).HasColumnName("InternalShippingId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.LocationCode).HasColumnName("LocationCode");
            this.Property(t => t.NominationId).HasColumnName("NominationId");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.IsLatest).HasColumnName("IsLatest");
            this.Property(t => t.IsBuy).HasColumnName("IsBuy");
            this.Property(t => t.ConfirmCreatedDate).HasColumnName("ConfirmCreatedDate");
            this.Property(t => t.EffectiveHour).HasColumnName("EffectiveHour");
        }
    }
}
