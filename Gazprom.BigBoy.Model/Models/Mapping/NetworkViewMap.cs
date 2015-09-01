using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NetworkViewMap : EntityTypeConfiguration<NetworkView>
    {
        public NetworkViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasNetworkId, t.Name, t.HourlyCapacityCheck, t.BalancingTypeId, t.BalancingTypeName, t.PreventSiblingNomination, t.PositionNetting, t.CodeSwitch });

            // Properties
            this.Property(t => t.GasNetworkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BalancingTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BalancingTypeName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NetworkView", "caprpt");
            this.Property(t => t.GasNetworkId).HasColumnName("GasNetworkId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HourlyCapacityCheck).HasColumnName("HourlyCapacityCheck");
            this.Property(t => t.BalancingTypeId).HasColumnName("BalancingTypeId");
            this.Property(t => t.BalancingTypeName).HasColumnName("BalancingTypeName");
            this.Property(t => t.ParentNetworkId).HasColumnName("ParentNetworkId");
            this.Property(t => t.PreventSiblingNomination).HasColumnName("PreventSiblingNomination");
            this.Property(t => t.PositionNetting).HasColumnName("PositionNetting");
            this.Property(t => t.CodeSwitch).HasColumnName("CodeSwitch");
        }
    }
}
