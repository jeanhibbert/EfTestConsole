using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class LocationTypeMap : EntityTypeConfiguration<LocationType>
    {
        public LocationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("LocationType");
            this.Property(t => t.LocationTypeId).HasColumnName("LocationTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
