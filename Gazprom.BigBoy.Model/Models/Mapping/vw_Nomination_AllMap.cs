using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class vw_Nomination_AllMap : EntityTypeConfiguration<vw_Nomination_All>
    {
        public vw_Nomination_AllMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NominationId, t.GasNetworkId, t.Version, t.SubmissionDateTime, t.DeliveryDate, t.Status, t.Deleted, t.UpdatedBy, t.UpdatedOn, t.Unit });

            // Properties
            this.Property(t => t.NominationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasNetworkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Filename)
                .HasMaxLength(1000);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AcknowledgementFile)
                .HasMaxLength(1000);

            this.Property(t => t.ConfirmationFile)
                .HasMaxLength(1000);

            this.Property(t => t.AnomalyFile)
                .HasMaxLength(1000);

            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Unit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vw_Nomination_All");
            this.Property(t => t.NominationId).HasColumnName("NominationId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.SubmissionDateTime).HasColumnName("SubmissionDateTime");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.AcknowledgementFile).HasColumnName("AcknowledgementFile");
            this.Property(t => t.ConfirmationFile).HasColumnName("ConfirmationFile");
            this.Property(t => t.AnomalyFile).HasColumnName("AnomalyFile");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.Unit).HasColumnName("Unit");
        }
    }
}
