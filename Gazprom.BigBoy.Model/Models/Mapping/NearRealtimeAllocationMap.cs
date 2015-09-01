using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NearRealtimeAllocationMap : EntityTypeConfiguration<NearRealtimeAllocation>
    {
        public NearRealtimeAllocationMap()
        {
            // Primary Key
            this.HasKey(t => t.NearRealtimeAllocationsId);

            // Properties
            this.Property(t => t.NetworkPointName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GasLocation)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NearRealtimeAllocations");
            this.Property(t => t.NearRealtimeAllocationsId).HasColumnName("NearRealtimeAllocationsId");
            this.Property(t => t.NetworkPointName).HasColumnName("NetworkPointName");
            this.Property(t => t.AllocationDateTime).HasColumnName("AllocationDateTime");
            this.Property(t => t.EnergyVolume).HasColumnName("EnergyVolume");
            this.Property(t => t.EnergyUnit).HasColumnName("EnergyUnit");
            this.Property(t => t.ConfirmedEnergyVolume).HasColumnName("ConfirmedEnergyVolume");
            this.Property(t => t.ConfirmedEnergyUnit).HasColumnName("ConfirmedEnergyUnit");
            this.Property(t => t.CalorificMeasure).HasColumnName("CalorificMeasure");
            this.Property(t => t.CalorificMeasureUnit).HasColumnName("CalorificMeasureUnit");
            this.Property(t => t.DownloadDateTime).HasColumnName("DownloadDateTime");
            this.Property(t => t.GasLocation).HasColumnName("GasLocation");

            // Relationships
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.NearRealtimeAllocations)
                .HasForeignKey(d => d.CalorificMeasureUnit);
            this.HasRequired(t => t.Unit1)
                .WithMany(t => t.NearRealtimeAllocations1)
                .HasForeignKey(d => d.ConfirmedEnergyUnit);
            this.HasRequired(t => t.Unit2)
                .WithMany(t => t.NearRealtimeAllocations2)
                .HasForeignKey(d => d.EnergyUnit);

        }
    }
}
