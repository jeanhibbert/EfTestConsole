using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class EndurVolumeTypeMap : EntityTypeConfiguration<EndurVolumeType>
    {
        public EndurVolumeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EndurVolumeTypeId);

            // Properties
            this.Property(t => t.EndurVolumeTypeName)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("EndurVolumeType");
            this.Property(t => t.EndurVolumeTypeId).HasColumnName("EndurVolumeTypeId");
            this.Property(t => t.EndurVolumeTypeName).HasColumnName("EndurVolumeTypeName");
        }
    }
}
