using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class SBSBufferZoneMap : EntityTypeConfiguration<SBSBufferZone>
    {
        public SBSBufferZoneMap()
        {
            // Primary Key
            this.HasKey(t => t.SBSBufferZonesId);

            // Properties
            this.Property(t => t.ZoneName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SBSBufferZones");
            this.Property(t => t.SBSBufferZonesId).HasColumnName("SBSBufferZonesId");
            this.Property(t => t.ZoneName).HasColumnName("ZoneName");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.BorderMaxEnergyAmount).HasColumnName("BorderMaxEnergyAmount");
            this.Property(t => t.BorderMinEnergyAmount).HasColumnName("BorderMinEnergyAmount");
            this.Property(t => t.AccountableSBSId).HasColumnName("AccountableSBSId");

            // Relationships
            this.HasRequired(t => t.AccountableSB)
                .WithMany(t => t.SBSBufferZones)
                .HasForeignKey(d => d.AccountableSBSId);

        }
    }
}
