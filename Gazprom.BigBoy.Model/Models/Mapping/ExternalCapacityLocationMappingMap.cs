using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class ExternalCapacityLocationMappingMap : EntityTypeConfiguration<ExternalCapacityLocationMapping>
    {
        public ExternalCapacityLocationMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.ExternalCapacityLocationMappingId);

            // Properties
            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EndurContractRef)
                .HasMaxLength(50);

            this.Property(t => t.ExitCode)
                .HasMaxLength(50);

            this.Property(t => t.EntryCode)
                .HasMaxLength(50);

            this.Property(t => t.PipelineName)
                .HasMaxLength(100);

            this.Property(t => t.ExternalSource)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.EditedBy)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ExternalCapacityLocationMapping");
            this.Property(t => t.ExternalCapacityLocationMappingId).HasColumnName("ExternalCapacityLocationMappingId");
            this.Property(t => t.ParentLocationId).HasColumnName("ParentLocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.EndurContractRef).HasColumnName("EndurContractRef");
            this.Property(t => t.ExitCode).HasColumnName("ExitCode");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.PipelineName).HasColumnName("PipelineName");
            this.Property(t => t.QueryGeminiForExitCapacity).HasColumnName("QueryGeminiForExitCapacity");
            this.Property(t => t.ExternalSource).HasColumnName("ExternalSource");
            this.Property(t => t.EditedOn).HasColumnName("EditedOn");
            this.Property(t => t.EditedBy).HasColumnName("EditedBy");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.ExternalCapacityLocationMappings)
                .HasForeignKey(d => d.ParentLocationId);

        }
    }
}
