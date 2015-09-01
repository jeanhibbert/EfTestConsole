using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UnitConversionViewMap : EntityTypeConfiguration<UnitConversionView>
    {
        public UnitConversionViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UnitConversionId, t.Unit, t.IsRate, t.IsGcvFactor, t.ToKwhFactor });

            // Properties
            this.Property(t => t.UnitConversionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.ToKwhFactor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UnitConversionView", "caprpt");
            this.Property(t => t.UnitConversionId).HasColumnName("UnitConversionId");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.IsRate).HasColumnName("IsRate");
            this.Property(t => t.IsGcvFactor).HasColumnName("IsGcvFactor");
            this.Property(t => t.ToKwhFactor).HasColumnName("ToKwhFactor");
        }
    }
}
