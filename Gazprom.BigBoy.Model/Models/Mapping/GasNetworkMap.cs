using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasNetworkMap : EntityTypeConfiguration<GasNetwork>
    {
        public GasNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.GasNetworkId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.EICCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GasNetwork");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BalancingTypeId).HasColumnName("BalancingTypeId");
            this.Property(t => t.BalancingUnitId).HasColumnName("BalancingUnitId");
            this.Property(t => t.PositionNetting).HasColumnName("PositionNetting");
            this.Property(t => t.NetworkTypeId).HasColumnName("NetworkTypeId");
            this.Property(t => t.ParentNetworkId).HasColumnName("ParentNetworkId");
            this.Property(t => t.ParentNominates).HasColumnName("ParentNominates");
            this.Property(t => t.CodeSwitch).HasColumnName("CodeSwitch");
            this.Property(t => t.EntryExitNetwork).HasColumnName("EntryExitNetwork");
            this.Property(t => t.TransitNetwork).HasColumnName("TransitNetwork");
            this.Property(t => t.IncludeFutures).HasColumnName("IncludeFutures");
            this.Property(t => t.ProgramBalance).HasColumnName("ProgramBalance");
            this.Property(t => t.PreventSiblingNomination).HasColumnName("PreventSiblingNomination");
            this.Property(t => t.PointX).HasColumnName("PointX");
            this.Property(t => t.PointY).HasColumnName("PointY");
            this.Property(t => t.IsNetworkLevelBalancing).HasColumnName("IsNetworkLevelBalancing");
            this.Property(t => t.Hide).HasColumnName("Hide");
            this.Property(t => t.CounterpartyMatches).HasColumnName("CounterpartyMatches");
            this.Property(t => t.OneFilePerContractRef).HasColumnName("OneFilePerContractRef");
            this.Property(t => t.HourlyCapacityCheck).HasColumnName("HourlyCapacityCheck");
            this.Property(t => t.ExcludeFromParentTotal).HasColumnName("ExcludeFromParentTotal");
            this.Property(t => t.EICCode).HasColumnName("EICCode");
            this.Property(t => t.UseBasicNominationAggregation).HasColumnName("UseBasicNominationAggregation");

            // Relationships
            this.HasRequired(t => t.BalancingType)
                .WithMany(t => t.GasNetworks)
                .HasForeignKey(d => d.BalancingTypeId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.GasNetworks)
                .HasForeignKey(d => d.BalancingUnitId);
            this.HasOptional(t => t.GasNetwork2)
                .WithMany(t => t.GasNetwork1)
                .HasForeignKey(d => d.ParentNetworkId);
            this.HasRequired(t => t.NetworkType)
                .WithMany(t => t.GasNetworks)
                .HasForeignKey(d => d.NetworkTypeId);

        }
    }
}
