using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TransitRouteLegAuditMap : EntityTypeConfiguration<TransitRouteLegAudit>
    {
        public TransitRouteLegAuditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TransitRouteLegId, t.TransitRouteId, t.LegNumber, t.AuditDate });

            // Properties
            this.Property(t => t.TransitRouteLegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TransitRouteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LegNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.ToCapacityInstrumentType)
                .HasMaxLength(64);

            this.Property(t => t.FromLineName)
                .HasMaxLength(64);

            this.Property(t => t.ToLineName)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("TransitRouteLegAudit");
            this.Property(t => t.TransitRouteLegId).HasColumnName("TransitRouteLegId");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.LegNumber).HasColumnName("LegNumber");
            this.Property(t => t.FromShipperId).HasColumnName("FromShipperId");
            this.Property(t => t.ToShipperId).HasColumnName("ToShipperId");
            this.Property(t => t.FromCapacityInstrumentType).HasColumnName("FromCapacityInstrumentType");
            this.Property(t => t.ToCapacityInstrumentType).HasColumnName("ToCapacityInstrumentType");
            this.Property(t => t.FromLineName).HasColumnName("FromLineName");
            this.Property(t => t.ToLineName).HasColumnName("ToLineName");
            this.Property(t => t.PipelineId).HasColumnName("PipelineId");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
        }
    }
}
