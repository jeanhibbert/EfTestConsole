using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class EnomMessageFieldMap : EntityTypeConfiguration<EnomMessageField>
    {
        public EnomMessageFieldMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FieldNameValue)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EnomMessageField");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FieldNameValue).HasColumnName("FieldNameValue");
        }
    }
}
