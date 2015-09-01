using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationVolumes_ArchiveMap : EntityTypeConfiguration<NominationVolumes_Archive>
    {
        public NominationVolumes_ArchiveMap()
        {
            // Primary Key
            this.HasKey(t => t.NominationVolumesId);

            // Properties
            this.Property(t => t.NominationVolumesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("NominationVolumes_Archive");
            this.Property(t => t.NominationVolumesId).HasColumnName("NominationVolumesId");
            this.Property(t => t.NominationShipperId).HasColumnName("NominationShipperId");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.VolumeNominated).HasColumnName("VolumeNominated");
            this.Property(t => t.CounterpartyNominated).HasColumnName("CounterpartyNominated");
            this.Property(t => t.AllocatedVolume).HasColumnName("AllocatedVolume");
            this.Property(t => t.IsExitFlow).HasColumnName("IsExitFlow");
            this.Property(t => t.IsEntryFlow).HasColumnName("IsEntryFlow");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
        }
    }
}
