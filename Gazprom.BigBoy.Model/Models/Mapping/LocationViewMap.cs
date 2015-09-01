using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class LocationViewMap : EntityTypeConfiguration<LocationView>
    {
        public LocationViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasLocationId, t.DisplayName, t.TimezoneName, t.CapacityNetting, t.GasNetworkId, t.CapacityTimeZoneCode, t.CapacityTimeZoneName, t.IsNominated, t.LocationTypeId });

            // Properties
            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(24);

            this.Property(t => t.TimeZoneCode)
                .HasMaxLength(50);

            this.Property(t => t.TimezoneName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GasNetworkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CapacityTimeZoneCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CapacityTimeZoneName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GazpromTransitCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LocationView", "caprpt");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.TimeZoneCode).HasColumnName("TimeZoneCode");
            this.Property(t => t.TimezoneName).HasColumnName("TimezoneName");
            this.Property(t => t.CapacityNetting).HasColumnName("CapacityNetting");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.CapacityTimeZoneCode).HasColumnName("CapacityTimeZoneCode");
            this.Property(t => t.CapacityTimeZoneName).HasColumnName("CapacityTimeZoneName");
            this.Property(t => t.IsNominated).HasColumnName("IsNominated");
            this.Property(t => t.LocationTypeId).HasColumnName("LocationTypeId");
            this.Property(t => t.GazpromTransitCode).HasColumnName("GazpromTransitCode");
        }
    }
}
