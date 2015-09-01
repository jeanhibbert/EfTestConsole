using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasLocationMappingMap : EntityTypeConfiguration<GasLocationMapping>
    {
        public GasLocationMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.GasLocationMappingId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("GasLocationMapping");
            this.Property(t => t.GasLocationMappingId).HasColumnName("GasLocationMappingId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasLocationMappings)
                .HasForeignKey(d => d.GasLocationId);

        }
    }
}
