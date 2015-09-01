using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationSystemTypeMap : EntityTypeConfiguration<NominationSystemType>
    {
        public NominationSystemTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.NominationSystemTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NominationSystemType");
            this.Property(t => t.NominationSystemTypeId).HasColumnName("NominationSystemTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
