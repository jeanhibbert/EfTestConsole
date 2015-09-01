using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GeminiCapacityTradeViewMap : EntityTypeConfiguration<GeminiCapacityTradeView>
    {
        public GeminiCapacityTradeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CapacityDay, t.IsEntry, t.GasLocationId, t.ExternalSource });

            // Properties
            this.Property(t => t.ContractReference)
                .HasMaxLength(50);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PipelineName)
                .HasMaxLength(100);

            this.Property(t => t.ExternalSource)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("GeminiCapacityTradeView", "caprpt");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
            this.Property(t => t.CapacityDay).HasColumnName("CapacityDay");
            this.Property(t => t.NetFirmCapacity).HasColumnName("NetFirmCapacity");
            this.Property(t => t.NetInterruptibleCapacity).HasColumnName("NetInterruptibleCapacity");
            this.Property(t => t.IsEntry).HasColumnName("IsEntry");
            this.Property(t => t.ContractReference).HasColumnName("ContractReference");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.PipelineName).HasColumnName("PipelineName");
            this.Property(t => t.ExternalSource).HasColumnName("ExternalSource");
        }
    }
}
