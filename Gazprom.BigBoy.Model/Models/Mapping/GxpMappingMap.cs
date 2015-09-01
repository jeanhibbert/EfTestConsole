using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GxpMappingMap : EntityTypeConfiguration<GxpMapping>
    {
        public GxpMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.GxpMappingsId);

            // Properties
            this.Property(t => t.OurLocationCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.GxpLocationCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.OurShipperCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.GxpShipperCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.OurInternalShippingCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.GxpInternalShippingCode)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("GxpMappings");
            this.Property(t => t.GxpMappingsId).HasColumnName("GxpMappingsId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.OurLocationCode).HasColumnName("OurLocationCode");
            this.Property(t => t.GxpLocationCode).HasColumnName("GxpLocationCode");
            this.Property(t => t.OurShipperCode).HasColumnName("OurShipperCode");
            this.Property(t => t.GxpShipperCode).HasColumnName("GxpShipperCode");
            this.Property(t => t.OurInternalShippingCode).HasColumnName("OurInternalShippingCode");
            this.Property(t => t.GxpInternalShippingCode).HasColumnName("GxpInternalShippingCode");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GxpMappings)
                .HasForeignKey(d => d.GasLocationId);

        }
    }
}
