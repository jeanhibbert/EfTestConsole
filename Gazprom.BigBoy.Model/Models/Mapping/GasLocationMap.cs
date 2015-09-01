using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasLocationMap : EntityTypeConfiguration<GasLocation>
    {
        public GasLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.GasLocationId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(24);

            this.Property(t => t.GazpromTransitCode)
                .HasMaxLength(50);

            this.Property(t => t.LocationCode)
                .HasMaxLength(50);

            this.Property(t => t.GazpromReference)
                .HasMaxLength(64);

            this.Property(t => t.GeminiNetworkId)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.GeminiExitNetwork)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TimezoneName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CapacityTimezoneName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TimezoneCode)
                .HasMaxLength(50);

            this.Property(t => t.CapacityTimezoneCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GasLocation");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.LocationTypeId).HasColumnName("LocationTypeId");
            this.Property(t => t.GazpromTransitCode).HasColumnName("GazpromTransitCode");
            this.Property(t => t.LocationCode).HasColumnName("LocationCode");
            this.Property(t => t.IsNominated).HasColumnName("IsNominated");
            this.Property(t => t.IsBalancing).HasColumnName("IsBalancing");
            this.Property(t => t.ZeroNominated).HasColumnName("ZeroNominated");
            this.Property(t => t.PointX).HasColumnName("PointX");
            this.Property(t => t.PointY).HasColumnName("PointY");
            this.Property(t => t.GazpromReference).HasColumnName("GazpromReference");
            this.Property(t => t.MatchingTolerance).HasColumnName("MatchingTolerance");
            this.Property(t => t.ByHour).HasColumnName("ByHour");
            this.Property(t => t.Hide).HasColumnName("Hide");
            this.Property(t => t.GeminiNetworkId).HasColumnName("GeminiNetworkId");
            this.Property(t => t.IsLocationLevelBalancing).HasColumnName("IsLocationLevelBalancing");
            this.Property(t => t.ConfirmationBeforeNomination).HasColumnName("ConfirmationBeforeNomination");
            this.Property(t => t.CapacityNetting).HasColumnName("CapacityNetting");
            this.Property(t => t.DisplayPendingOnZeroPosition).HasColumnName("DisplayPendingOnZeroPosition");
            this.Property(t => t.GeminiExitNetwork).HasColumnName("GeminiExitNetwork");
            this.Property(t => t.DoNotNominateHistoric).HasColumnName("DoNotNominateHistoric");
            this.Property(t => t.DailyMeteredShipper).HasColumnName("DailyMeteredShipper");
            this.Property(t => t.NonDailyMeteredShipper).HasColumnName("NonDailyMeteredShipper");
            this.Property(t => t.TimezoneName).HasColumnName("TimezoneName");
            this.Property(t => t.CapacityTimezoneName).HasColumnName("CapacityTimezoneName");
            this.Property(t => t.TimezoneCode).HasColumnName("TimezoneCode");
            this.Property(t => t.CapacityTimezoneCode).HasColumnName("CapacityTimezoneCode");

            // Relationships
            this.HasOptional(t => t.GasShipper)
                .WithMany(t => t.GasLocations)
                .HasForeignKey(d => d.DailyMeteredShipper);
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.GasLocations)
                .HasForeignKey(d => d.GasNetworkId);
            this.HasRequired(t => t.LocationType)
                .WithMany(t => t.GasLocations)
                .HasForeignKey(d => d.LocationTypeId);
            this.HasOptional(t => t.GasShipper1)
                .WithMany(t => t.GasLocations1)
                .HasForeignKey(d => d.NonDailyMeteredShipper);

        }
    }
}
