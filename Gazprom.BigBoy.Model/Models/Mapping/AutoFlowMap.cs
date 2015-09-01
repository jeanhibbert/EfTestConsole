using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class AutoFlowMap : EntityTypeConfiguration<AutoFlow>
    {
        public AutoFlowMap()
        {
            // Primary Key
            this.HasKey(t => t.AutoFlowId);

            // Properties
            // Table & Column Mappings
            this.ToTable("AutoFlow");
            this.Property(t => t.AutoFlowId).HasColumnName("AutoFlowId");
            this.Property(t => t.GasPipelineId).HasColumnName("GasPipelineId");
            this.Property(t => t.Disable).HasColumnName("Disable");

            // Relationships
            this.HasRequired(t => t.GasPipeline)
                .WithMany(t => t.AutoFlows)
                .HasForeignKey(d => d.GasPipelineId);

        }
    }
}
