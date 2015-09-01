using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class SendInformationMap : EntityTypeConfiguration<SendInformation>
    {
        public SendInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.SendInformationId);

            // Properties
            this.Property(t => t.GeminiLogin)
                .HasMaxLength(500);

            this.Property(t => t.GeminiPassword)
                .HasMaxLength(500);

            this.Property(t => t.LiveEmailAddress)
                .HasMaxLength(2500);

            this.Property(t => t.FromEmailAddress)
                .HasMaxLength(2500);

            this.Property(t => t.SendInformationName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("SendInformation");
            this.Property(t => t.SendInformationId).HasColumnName("SendInformationId");
            this.Property(t => t.NominationsSystemTypeId).HasColumnName("NominationsSystemTypeId");
            this.Property(t => t.SendTypeId).HasColumnName("SendTypeId");
            this.Property(t => t.LiveFileShare).HasColumnName("LiveFileShare");
            this.Property(t => t.GeminiRoot).HasColumnName("GeminiRoot");
            this.Property(t => t.GeminiLogin).HasColumnName("GeminiLogin");
            this.Property(t => t.GeminiPassword).HasColumnName("GeminiPassword");
            this.Property(t => t.LiveEmailAddress).HasColumnName("LiveEmailAddress");
            this.Property(t => t.FromEmailAddress).HasColumnName("FromEmailAddress");
            this.Property(t => t.LastPasswordResetUtc).HasColumnName("LastPasswordResetUtc");
            this.Property(t => t.CopyFileShare).HasColumnName("CopyFileShare");
            this.Property(t => t.SendInformationName).HasColumnName("SendInformationName");
            this.Property(t => t.GeminiServiceIdBuy).HasColumnName("GeminiServiceIdBuy");
            this.Property(t => t.GeminiServiceIdSell).HasColumnName("GeminiServiceIdSell");

            // Relationships
            this.HasOptional(t => t.NominationSystemType)
                .WithMany(t => t.SendInformations)
                .HasForeignKey(d => d.NominationsSystemTypeId);
            this.HasRequired(t => t.SendType)
                .WithMany(t => t.SendInformations)
                .HasForeignKey(d => d.SendTypeId);

        }
    }
}
