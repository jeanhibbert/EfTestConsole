using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasNetworkDisplayCapacityProductMap : EntityTypeConfiguration<GasNetworkDisplayCapacityProduct>
    {
        public GasNetworkDisplayCapacityProductMap()
        {
            // Primary Key
            this.HasKey(t => t.GasNetworkDisplayCapacityProductId);

            // Properties
            this.Property(t => t.OverviewAbbreviation)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("GasNetworkDisplayCapacityProduct");
            this.Property(t => t.GasNetworkDisplayCapacityProductId).HasColumnName("GasNetworkDisplayCapacityProductId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.EndurCapacityProductId).HasColumnName("EndurCapacityProductId");
            this.Property(t => t.OverviewAbbreviation).HasColumnName("OverviewAbbreviation");

            // Relationships
            this.HasRequired(t => t.EndurCapacityProduct)
                .WithMany(t => t.GasNetworkDisplayCapacityProducts)
                .HasForeignKey(d => d.EndurCapacityProductId);
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.GasNetworkDisplayCapacityProducts)
                .HasForeignKey(d => d.GasNetworkId);

        }
    }
}
