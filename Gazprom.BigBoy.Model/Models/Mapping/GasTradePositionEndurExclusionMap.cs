using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTradePositionEndurExclusionMap : EntityTypeConfiguration<GasTradePositionEndurExclusion>
    {
        public GasTradePositionEndurExclusionMap()
        {
            // Primary Key
            this.HasKey(t => t.GasTradePositionEndurExclusionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("GasTradePositionEndurExclusion");
            this.Property(t => t.GasTradePositionEndurExclusionId).HasColumnName("GasTradePositionEndurExclusionId");
            this.Property(t => t.EndurInstrumentTypeId).HasColumnName("EndurInstrumentTypeId");
            this.Property(t => t.EndurVolumeTypeId).HasColumnName("EndurVolumeTypeId");

            // Relationships
            this.HasRequired(t => t.EndurInstrumentType)
                .WithMany(t => t.GasTradePositionEndurExclusions)
                .HasForeignKey(d => d.EndurInstrumentTypeId);
            this.HasRequired(t => t.EndurVolumeType)
                .WithMany(t => t.GasTradePositionEndurExclusions)
                .HasForeignKey(d => d.EndurVolumeTypeId);

        }
    }
}
