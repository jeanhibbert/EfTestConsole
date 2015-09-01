using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class CapacityInstrumentTypeMap : EntityTypeConfiguration<CapacityInstrumentType>
    {
        public CapacityInstrumentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CapacityInstrumentTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CapacityInstrumentType");
            this.Property(t => t.CapacityInstrumentTypeId).HasColumnName("CapacityInstrumentTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
