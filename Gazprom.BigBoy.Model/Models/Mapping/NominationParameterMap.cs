using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationParameterMap : EntityTypeConfiguration<NominationParameter>
    {
        public NominationParameterMap()
        {
            // Primary Key
            this.HasKey(t => t.NominationsParametersId);

            // Properties
            this.Property(t => t.EnomFrom)
                .HasMaxLength(100);

            this.Property(t => t.EnomFromNad)
                .HasMaxLength(100);

            this.Property(t => t.EnomTo)
                .HasMaxLength(100);

            this.Property(t => t.EnomToNad)
                .HasMaxLength(100);

            this.Property(t => t.EnomUnit)
                .HasMaxLength(100);

            this.Property(t => t.EnomContractRef)
                .HasMaxLength(100);

            this.Property(t => t.EnomGCVUnit)
                .HasMaxLength(100);

            this.Property(t => t.ZeroNominationsPoint)
                .HasMaxLength(200);

            this.Property(t => t.InternalShipperCode)
                .HasMaxLength(100);

            this.Property(t => t.EnomVersionType)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("NominationParameters");
            this.Property(t => t.NominationsParametersId).HasColumnName("NominationsParametersId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.NominationSystemTypeId).HasColumnName("NominationSystemTypeId");
            this.Property(t => t.EnomXML).HasColumnName("EnomXML");
            this.Property(t => t.EnomEDI).HasColumnName("EnomEDI");
            this.Property(t => t.EnomFrom).HasColumnName("EnomFrom");
            this.Property(t => t.EnomFromNad).HasColumnName("EnomFromNad");
            this.Property(t => t.EnomTo).HasColumnName("EnomTo");
            this.Property(t => t.EnomToNad).HasColumnName("EnomToNad");
            this.Property(t => t.EnomUnit).HasColumnName("EnomUnit");
            this.Property(t => t.EnomContractRef).HasColumnName("EnomContractRef");
            this.Property(t => t.EnomGCVUnit).HasColumnName("EnomGCVUnit");
            this.Property(t => t.EnomGCV).HasColumnName("EnomGCV");
            this.Property(t => t.EnomUseQualifiedValues).HasColumnName("EnomUseQualifiedValues");
            this.Property(t => t.EnomAlwaysInputOutput).HasColumnName("EnomAlwaysInputOutput");
            this.Property(t => t.IsHourlyNominated).HasColumnName("IsHourlyNominated");
            this.Property(t => t.Enom1MessagePerPoint).HasColumnName("Enom1MessagePerPoint");
            this.Property(t => t.EnomVersion).HasColumnName("EnomVersion");
            this.Property(t => t.EnomShrinkageFactor).HasColumnName("EnomShrinkageFactor");
            this.Property(t => t.ZeroNominationsPoint).HasColumnName("ZeroNominationsPoint");
            this.Property(t => t.EnomIsHubNotice).HasColumnName("EnomIsHubNotice");
            this.Property(t => t.IsStorageNotice).HasColumnName("IsStorageNotice");
            this.Property(t => t.InternalShipperCode).HasColumnName("InternalShipperCode");
            this.Property(t => t.EnomVersionType).HasColumnName("EnomVersionType");
            this.Property(t => t.RemoveEnomTags).HasColumnName("RemoveEnomTags");
            this.Property(t => t.EnomBDRMessage).HasColumnName("EnomBDRMessage");
            this.Property(t => t.CapacityNomination).HasColumnName("CapacityNomination");
            this.Property(t => t.UseEICCodeForConnectedNetwork).HasColumnName("UseEICCodeForConnectedNetwork");
            this.Property(t => t.ContractRefAndInternalShipperPair).HasColumnName("ContractRefAndInternalShipperPair");
            this.Property(t => t.EnomOverrideGasDayStartHour).HasColumnName("EnomOverrideGasDayStartHour");

            // Relationships
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.NominationParameters)
                .HasForeignKey(d => d.GasNetworkId);
            this.HasRequired(t => t.NominationSystemType)
                .WithMany(t => t.NominationParameters)
                .HasForeignKey(d => d.NominationSystemTypeId);

        }
    }
}
