using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NominationValidationMap : EntityTypeConfiguration<NominationValidation>
    {
        public NominationValidationMap()
        {
            // Primary Key
            this.HasKey(t => t.NominationValidationId);

            // Properties
            this.Property(t => t.ContractRef)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NominationValidation");
            this.Property(t => t.NominationValidationId).HasColumnName("NominationValidationId");
            this.Property(t => t.ContractRef).HasColumnName("ContractRef");
            this.Property(t => t.ValidationTypeId).HasColumnName("ValidationTypeId");

            // Relationships
            this.HasRequired(t => t.ValidationType)
                .WithMany(t => t.NominationValidations)
                .HasForeignKey(d => d.ValidationTypeId);

        }
    }
}
