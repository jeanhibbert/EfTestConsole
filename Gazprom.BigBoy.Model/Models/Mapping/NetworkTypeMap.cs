using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NetworkTypeMap : EntityTypeConfiguration<NetworkType>
    {
        public NetworkTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NetworkTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NetworkType");
            this.Property(t => t.NetworkTypeId).HasColumnName("NetworkTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
