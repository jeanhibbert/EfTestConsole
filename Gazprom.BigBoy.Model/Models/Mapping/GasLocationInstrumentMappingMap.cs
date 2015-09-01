using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasLocationInstrumentMappingMap : EntityTypeConfiguration<GasLocationInstrumentMapping>
    {
        public GasLocationInstrumentMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.GasLocationInstrumentMappingId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GasLocationInstrumentMapping");
            this.Property(t => t.GasLocationInstrumentMappingId).HasColumnName("GasLocationInstrumentMappingId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.EndurInstrumentTypeId).HasColumnName("EndurInstrumentTypeId");

            // Relationships
            this.HasRequired(t => t.EndurInstrumentType)
                .WithMany(t => t.GasLocationInstrumentMappings)
                .HasForeignKey(d => d.EndurInstrumentTypeId);
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasLocationInstrumentMappings)
                .HasForeignKey(d => d.GasLocationId);

        }
    }
}
