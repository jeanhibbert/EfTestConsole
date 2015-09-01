using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class vw_NominationVolumes_AllMap : EntityTypeConfiguration<vw_NominationVolumes_All>
    {
        public vw_NominationVolumes_AllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NominationVolumesId, t.NominationShipperId, t.Hour, t.StartTime, t.EndTime, t.VolumeNominated, t.CounterpartyNominated, t.IsExitFlow, t.IsEntryFlow, t.UpdatedBy, t.UpdatedOn });

            // Properties
            this.Property(t => t.NominationVolumesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NominationShipperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hour)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VolumeNominated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CounterpartyNominated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("vw_NominationVolumes_All");
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
