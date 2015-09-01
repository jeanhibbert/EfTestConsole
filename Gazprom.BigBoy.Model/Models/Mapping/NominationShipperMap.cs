using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationShipperMap : EntityTypeConfiguration<NominationShipper>
    {
        public NominationShipperMap()
        {
            // Primary Key
            this.HasKey(t => t.NomiantionShipperId);

            // Properties
            this.Property(t => t.CounterpartyName)
                .HasMaxLength(200);

            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LocationCode)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NominationShipper");
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

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.NominationShippers)
                .HasForeignKey(d => d.GasLocationId);
            this.HasRequired(t => t.Nomination)
                .WithMany(t => t.NominationShippers)
                .HasForeignKey(d => d.NominationId);
            this.HasRequired(t => t.Status1)
                .WithMany(t => t.NominationShippers)
                .HasForeignKey(d => d.Status);

        }
    }
}
