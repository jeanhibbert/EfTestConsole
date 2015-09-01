using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UkLocationMappingViewMap : EntityTypeConfiguration<UkLocationMappingView>
    {
        public UkLocationMappingViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ParentLocationId, t.LocationName });

            // Properties
            this.Property(t => t.ParentLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EndurContractRef)
                .HasMaxLength(50);

            this.Property(t => t.PipelineName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("UkLocationMappingView", "caprpt");
            this.Property(t => t.ParentLocationId).HasColumnName("ParentLocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.EndurContractRef).HasColumnName("EndurContractRef");
            this.Property(t => t.PipelineName).HasColumnName("PipelineName");
        }
    }
}
