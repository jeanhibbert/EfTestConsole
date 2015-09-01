using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CapacityTradeMultiLegRouteMap : EntityTypeConfiguration<CapacityTradeMultiLegRoute>
    {
        public CapacityTradeMultiLegRouteMap()
        {
            // Primary Key
            this.HasKey(t => t.CapacityTradeMultiLegRouteId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ParentEndurLineName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ParentEndurCapacityType)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("CapacityTradeMultiLegRoute");
            this.Property(t => t.CapacityTradeMultiLegRouteId).HasColumnName("CapacityTradeMultiLegRouteId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentEndurLineName).HasColumnName("ParentEndurLineName");
            this.Property(t => t.ParentEndurCapacityType).HasColumnName("ParentEndurCapacityType");
        }
    }
}
