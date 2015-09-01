using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class LocationMappingViewMap : EntityTypeConfiguration<LocationMappingView>
    {
        public LocationMappingViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasLocationId, t.EndurLocationName, t.EndurInstrumentName });

            // Properties
            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EndurLocationName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.EndurInstrumentName)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("LocationMappingView", "caprpt");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.EndurLocationName).HasColumnName("EndurLocationName");
            this.Property(t => t.EndurInstrumentName).HasColumnName("EndurInstrumentName");
        }
    }
}
