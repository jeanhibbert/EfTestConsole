using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GeminiDataUpdatedViewMap : EntityTypeConfiguration<GeminiDataUpdatedView>
    {
        public GeminiDataUpdatedViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CapacityDay, t.IsEntry });

            // Properties
            // Table & Column Mappings
            this.ToTable("GeminiDataUpdatedView", "caprpt");
            this.Property(t => t.CapacityDay).HasColumnName("CapacityDay");
            this.Property(t => t.IsEntry).HasColumnName("IsEntry");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
        }
    }
}
