using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class AccountablePOSMap : EntityTypeConfiguration<AccountablePOS>
    {
        public AccountablePOSMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountablePOSId);

            // Properties
            this.Property(t => t.PortfolioGasId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountablePOS");
            this.Property(t => t.AccountablePOSId).HasColumnName("AccountablePOSId");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.EnergyVolume).HasColumnName("EnergyVolume");
            this.Property(t => t.EnergyUnit).HasColumnName("EnergyUnit");
            this.Property(t => t.PosDateTimeInCET).HasColumnName("PosDateTimeInCET");
            this.Property(t => t.DownloadTime).HasColumnName("DownloadTime");
            this.Property(t => t.PortfolioGasId).HasColumnName("PortfolioGasId");

            // Relationships
            this.HasRequired(t => t.GasNetwork)
                .WithMany(t => t.AccountablePOS)
                .HasForeignKey(d => d.GasNetworkId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.AccountablePOS)
                .HasForeignKey(d => d.EnergyUnit);

        }
    }
}
