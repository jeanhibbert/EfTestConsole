using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class FlowLineNameMappingMap : EntityTypeConfiguration<FlowLineNameMapping>
    {
        public FlowLineNameMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.FlowLineNameMappingId);

            // Properties
            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LineName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.InternalShippingCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FlowLineNameMapping");
            this.Property(t => t.FlowLineNameMappingId).HasColumnName("FlowLineNameMappingId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode");
            this.Property(t => t.LineName).HasColumnName("LineName");
            this.Property(t => t.IsEntry).HasColumnName("IsEntry");
            this.Property(t => t.PublishToEndur).HasColumnName("PublishToEndur");
            this.Property(t => t.InternalShippingCode).HasColumnName("InternalShippingCode");
            this.Property(t => t.CreateTransitPair).HasColumnName("CreateTransitPair");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.FlowLineNameMappings)
                .HasForeignKey(d => d.GasLocationId);

        }
    }
}
