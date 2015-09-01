using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class MultiLegCapacityTradeMappingMap : EntityTypeConfiguration<MultiLegCapacityTradeMapping>
    {
        public MultiLegCapacityTradeMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MultiLegCapacityTradeMappingId, t.ParentEndurLineName, t.ParentEndurCapacityType, t.LegNumber, t.GasLocationId, t.InstrumentTypeId, t.GasPipelineId, t.GasLocationDisplayName, t.CapacityProduct });

            // Properties
            this.Property(t => t.MultiLegCapacityTradeMappingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ParentEndurLineName)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.ParentEndurCapacityType)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.LegNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstrumentTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasPipelineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GasLocationDisplayName)
                .IsRequired()
                .HasMaxLength(24);

            this.Property(t => t.CapacityProduct)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.LineName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MultiLegCapacityTradeMapping", "caprpt");
            this.Property(t => t.MultiLegCapacityTradeMappingId).HasColumnName("MultiLegCapacityTradeMappingId");
            this.Property(t => t.ParentEndurLineName).HasColumnName("ParentEndurLineName");
            this.Property(t => t.ParentEndurCapacityType).HasColumnName("ParentEndurCapacityType");
            this.Property(t => t.LegNumber).HasColumnName("LegNumber");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.InstrumentTypeId).HasColumnName("InstrumentTypeId");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.GasLocationDisplayName).HasColumnName("GasLocationDisplayName");
            this.Property(t => t.CapacityProduct).HasColumnName("CapacityProduct");
            this.Property(t => t.LineName).HasColumnName("LineName");
        }
    }
}
