using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CommodityTypeMap : EntityTypeConfiguration<CommodityType>
    {
        public CommodityTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CommodityTypeId);

            // Properties
            this.Property(t => t.CommodityName)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("CommodityType");
            this.Property(t => t.CommodityTypeId).HasColumnName("CommodityTypeId");
            this.Property(t => t.CommodityName).HasColumnName("CommodityName");
        }
    }
}
