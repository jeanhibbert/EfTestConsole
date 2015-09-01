using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class BalancingTypeMap : EntityTypeConfiguration<BalancingType>
    {
        public BalancingTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BalancingTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BalancingType");
            this.Property(t => t.BalancingTypeId).HasColumnName("BalancingTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
