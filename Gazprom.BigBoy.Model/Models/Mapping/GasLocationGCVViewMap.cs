using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasLocationGCVViewMap : EntityTypeConfiguration<GasLocationGCVView>
    {
        public GasLocationGCVViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GasLocationGCVId, t.GasLocationId, t.ValidFrom, t.ValidTo, t.CalorificValue });

            // Properties
            this.Property(t => t.GasLocationGCVId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GasLocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CalorificValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GasLocationGCVView", "caprpt");
            this.Property(t => t.GasLocationGCVId).HasColumnName("GasLocationGCVId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.CalorificValue).HasColumnName("CalorificValue");
        }
    }
}
