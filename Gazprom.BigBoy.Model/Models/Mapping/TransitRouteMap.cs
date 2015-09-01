using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TransitRouteMap : EntityTypeConfiguration<TransitRoute>
    {
        public TransitRouteMap()
        {
            // Primary Key
            this.HasKey(t => t.TransitRouteId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.EditedBy)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TransitRoute");
            this.Property(t => t.TransitRouteId).HasColumnName("TransitRouteId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.EditedOn).HasColumnName("EditedOn");
            this.Property(t => t.EditedBy).HasColumnName("EditedBy");
        }
    }
}
