using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class AccountableSBMap : EntityTypeConfiguration<AccountableSB>
    {
        public AccountableSBMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountableSBSId);

            // Properties
            // Table & Column Mappings
            this.ToTable("AccountableSBS");
            this.Property(t => t.AccountableSBSId).HasColumnName("AccountableSBSId");
            this.Property(t => t.EnergyData).HasColumnName("EnergyData");
            this.Property(t => t.EnergyUnit).HasColumnName("EnergyUnit");
            this.Property(t => t.SBSDateTime).HasColumnName("SBSDateTime");
            this.Property(t => t.SumHelpersEnergyAmount).HasColumnName("SumHelpersEnergyAmount");
            this.Property(t => t.SumCausersEnergyAmount).HasColumnName("SumCausersEnergyAmount");

            // Relationships
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.AccountableSBS)
                .HasForeignKey(d => d.EnergyUnit);

        }
    }
}
