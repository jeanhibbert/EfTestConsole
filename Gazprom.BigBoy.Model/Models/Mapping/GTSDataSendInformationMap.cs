using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GTSDataSendInformationMap : EntityTypeConfiguration<GTSDataSendInformation>
    {
        public GTSDataSendInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.GTSDataSendInformationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GTSDataSendInformation");
            this.Property(t => t.GTSDataSendInformationId).HasColumnName("GTSDataSendInformationId");
            this.Property(t => t.POSEmailers).HasColumnName("POSEmailers");
            this.Property(t => t.SBAEmailers).HasColumnName("SBAEmailers");
            this.Property(t => t.POSEmailSent).HasColumnName("POSEmailSent");
            this.Property(t => t.SBSEmailSent).HasColumnName("SBSEmailSent");
        }
    }
}
