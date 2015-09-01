using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class TransitFlowMapperMap : EntityTypeConfiguration<TransitFlowMapper>
    {
        public TransitFlowMapperMap()
        {
            // Primary Key
            this.HasKey(t => t.TransitFlowMapperId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Route)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("TransitFlowMapper");
            this.Property(t => t.TransitFlowMapperId).HasColumnName("TransitFlowMapperId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Route).HasColumnName("Route");
        }
    }
}
