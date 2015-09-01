using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class PositionCheckMap : EntityTypeConfiguration<PositionCheck>
    {
        public PositionCheckMap()
        {
            // Primary Key
            this.HasKey(t => t.PositionCheckId);

            // Properties
            this.Property(t => t.TimezoneName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TimezoneCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PositionCheck");
            this.Property(t => t.PositionCheckId).HasColumnName("PositionCheckId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation");
            this.Property(t => t.Rounding).HasColumnName("Rounding");
            this.Property(t => t.TimezoneName).HasColumnName("TimezoneName");
            this.Property(t => t.TimezoneCode).HasColumnName("TimezoneCode");

            // Relationships
            this.HasOptional(t => t.GasNetwork)
                .WithMany(t => t.PositionChecks)
                .HasForeignKey(d => d.GasNetworkId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.PositionChecks)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
