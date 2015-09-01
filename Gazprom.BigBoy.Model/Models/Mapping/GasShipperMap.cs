using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasShipperMap : EntityTypeConfiguration<GasShipper>
    {
        public GasShipperMap()
        {
            // Primary Key
            this.HasKey(t => t.GasShipperId);

            // Properties
            this.Property(t => t.Counterparty)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GasShipper");
            this.Property(t => t.GasShipperId).HasColumnName("GasShipperId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.Counterparty).HasColumnName("Counterparty");
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode");
            this.Property(t => t.Notify).HasColumnName("Notify");
            this.Property(t => t.IncludeInPosition).HasColumnName("IncludeInPosition");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.DuplicateTrades).HasColumnName("DuplicateTrades");
            this.Property(t => t.InvertDuplicateTrades).HasColumnName("InvertDuplicateTrades");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasShippers)
                .HasForeignKey(d => d.GasLocationId);
            this.HasOptional(t => t.GasShipper2)
                .WithMany(t => t.GasShipper1)
                .HasForeignKey(d => d.DuplicateTrades);

        }
    }
}
