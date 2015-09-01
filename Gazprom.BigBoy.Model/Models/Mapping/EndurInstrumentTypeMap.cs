using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class EndurInstrumentTypeMap : EntityTypeConfiguration<EndurInstrumentType>
    {
        public EndurInstrumentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EndurInstrumentTypeId);

            // Properties
            this.Property(t => t.InstrumentName)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("EndurInstrumentType");
            this.Property(t => t.EndurInstrumentTypeId).HasColumnName("EndurInstrumentTypeId");
            this.Property(t => t.InstrumentName).HasColumnName("InstrumentName");
            this.Property(t => t.CommodityType).HasColumnName("CommodityType");

            // Relationships
            this.HasOptional(t => t.CommodityType1)
                .WithMany(t => t.EndurInstrumentTypes)
                .HasForeignKey(d => d.CommodityType);

        }
    }
}
