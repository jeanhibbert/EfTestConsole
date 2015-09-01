using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasLocationGCVMap : EntityTypeConfiguration<GasLocationGCV>
    {
        public GasLocationGCVMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasLocationGCVId, t.ValidFrom });

            // Properties
            this.Property(t => t.GasLocationGCVId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("GasLocationGCV");
            this.Property(t => t.GasLocationGCVId).HasColumnName("GasLocationGCVId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.CalorificValue).HasColumnName("CalorificValue");

            // Relationships
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.GasLocationGCVs)
                .HasForeignKey(d => d.GasLocationId);

        }
    }
}
