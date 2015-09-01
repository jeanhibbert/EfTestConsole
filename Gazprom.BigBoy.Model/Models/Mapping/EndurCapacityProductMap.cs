using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class EndurCapacityProductMap : EntityTypeConfiguration<EndurCapacityProduct>
    {
        public EndurCapacityProductMap()
        {
            // Primary Key
            this.HasKey(t => t.EndurCapacityProductId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("EndurCapacityProduct");
            this.Property(t => t.EndurCapacityProductId).HasColumnName("EndurCapacityProductId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
