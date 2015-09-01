using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NadAccountMap : EntityTypeConfiguration<NadAccount>
    {
        public NadAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.NadAccountId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("NadAccount");
            this.Property(t => t.NadAccountId).HasColumnName("NadAccountId");
            this.Property(t => t.NominationsParametersId).HasColumnName("NominationsParametersId");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.NominationParameter)
                .WithMany(t => t.NadAccounts)
                .HasForeignKey(d => d.NominationsParametersId);

        }
    }
}
