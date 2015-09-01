using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UnitConversionMap : EntityTypeConfiguration<UnitConversion>
    {
        public UnitConversionMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitConversionId);

            // Properties
            this.Property(t => t.Unit)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("UnitConversion");
            this.Property(t => t.UnitConversionId).HasColumnName("UnitConversionId");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.IsRate).HasColumnName("IsRate");
            this.Property(t => t.IsGcvFactor).HasColumnName("IsGcvFactor");
            this.Property(t => t.ToKwhFactor).HasColumnName("ToKwhFactor");
        }
    }
}
