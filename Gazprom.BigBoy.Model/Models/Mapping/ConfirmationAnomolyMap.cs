using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class ConfirmationAnomolyMap : EntityTypeConfiguration<ConfirmationAnomoly>
    {
        public ConfirmationAnomolyMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfirmationAnomolyId);

            // Properties
            this.Property(t => t.Filename)
                .HasMaxLength(1000);

            this.Property(t => t.LocationCode)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Counterparty)
                .HasMaxLength(128);

            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.InternalShipperCode)
                .HasMaxLength(64);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ConfirmationAnomoly");
            this.Property(t => t.ConfirmationAnomolyId).HasColumnName("ConfirmationAnomolyId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LocationCode).HasColumnName("LocationCode");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode");
            this.Property(t => t.InternalShipperCode).HasColumnName("InternalShipperCode");
            this.Property(t => t.StartDateUtc).HasColumnName("StartDateUtc");
            this.Property(t => t.EndDateUtc).HasColumnName("EndDateUtc");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.Nominated).HasColumnName("Nominated");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.ConfirmationAnomolies)
                .HasForeignKey(d => d.GasLocationId);
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.ConfirmationAnomolies)
                .HasForeignKey(d => d.GasNetworkId);
            this.HasRequired(t => t.Status1)
                .WithMany(t => t.ConfirmationAnomolies)
                .HasForeignKey(d => d.Status);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.ConfirmationAnomolies)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
