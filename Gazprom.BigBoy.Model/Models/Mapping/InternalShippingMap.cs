using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class InternalShippingMap : EntityTypeConfiguration<InternalShipping>
    {
        public InternalShippingMap()
        {
            // Primary Key
            this.HasKey(t => t.InternalShippingId);

            // Properties
            this.Property(t => t.GazpromTransitCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InternalShippingCode)
                .HasMaxLength(50);

            this.Property(t => t.ContractReference)
                .HasMaxLength(50);

            this.Property(t => t.EndurContractRef)
                .HasMaxLength(50);

            this.Property(t => t.OverrideEnomAdjacentLocation)
                .HasMaxLength(50);

            this.Property(t => t.LineContractReference)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InternalShipping");
            this.Property(t => t.InternalShippingId).HasColumnName("InternalShippingId");
            this.Property(t => t.GasLocationId).HasColumnName("GasLocationId");
            this.Property(t => t.GazpromTransitCode).HasColumnName("GazpromTransitCode");
            this.Property(t => t.InternalShippingCode).HasColumnName("InternalShippingCode");
            this.Property(t => t.ContractReference).HasColumnName("ContractReference");
            this.Property(t => t.EndurContractRef).HasColumnName("EndurContractRef");
            this.Property(t => t.NadAccountId).HasColumnName("NadAccountId");
            this.Property(t => t.EndurCapacityProductId).HasColumnName("EndurCapacityProductId");
            this.Property(t => t.OverrideEnomAdjacentTransitCode).HasColumnName("OverrideEnomAdjacentTransitCode");
            this.Property(t => t.OverrideEnomAdjacentLocation).HasColumnName("OverrideEnomAdjacentLocation");
            this.Property(t => t.LineContractReference).HasColumnName("LineContractReference");

            // Relationships
            this.HasOptional(t => t.EndurCapacityProduct)
                .WithMany(t => t.InternalShippings)
                .HasForeignKey(d => d.EndurCapacityProductId);
            this.HasRequired(t => t.GasLocation)
                .WithMany(t => t.InternalShippings)
                .HasForeignKey(d => d.GasLocationId);
            this.HasOptional(t => t.NadAccount)
                .WithMany(t => t.InternalShippings)
                .HasForeignKey(d => d.NadAccountId);

        }
    }
}
