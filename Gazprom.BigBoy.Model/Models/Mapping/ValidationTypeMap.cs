using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class ValidationTypeMap : EntityTypeConfiguration<ValidationType>
    {
        public ValidationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ValidationTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ValidationType");
            this.Property(t => t.ValidationTypeId).HasColumnName("ValidationTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
