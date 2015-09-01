using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TransitRouteAuditMap : EntityTypeConfiguration<TransitRouteAudit>
    {
        public TransitRouteAuditMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TransitRouteId, t.Name, t.IsDisabled, t.EditedOn, t.AuditDate });

            // Properties
            this.Property(t => t.TransitRouteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.EditedBy)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TransitRouteAudit");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.EditedOn).HasColumnName("EditedOn");
            this.Property(t => t.EditedBy).HasColumnName("EditedBy");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
        }
    }
}
