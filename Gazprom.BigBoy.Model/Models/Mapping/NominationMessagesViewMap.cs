using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationMessagesViewMap : EntityTypeConfiguration<NominationMessagesView>
    {
        public NominationMessagesViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NominationId, t.NomiantionShipperId, t.GasNetworkId, t.LocationCode, t.ShipperCode });

            // Properties
            this.Property(t => t.NominationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NomiantionShipperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasNetworkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShipperCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EnomToNad)
                .HasMaxLength(100);

            this.Property(t => t.EnomContractRef)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NominationMessagesView", "caprpt");
            this.Property(t => t.NominationId).HasColumnName("NominationId");
            this.Property(t => t.NomiantionShipperId).HasColumnName("NomiantionShipperId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.LocationCode).HasColumnName("LocationCode");
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode");
            this.Property(t => t.EnomToNad).HasColumnName("EnomToNad");
            this.Property(t => t.EnomContractRef).HasColumnName("EnomContractRef");
        }
    }
}
