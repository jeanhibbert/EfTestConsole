using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class UnitMap : EntityTypeConfiguration<Unit>
    {
        public UnitMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Unit");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.IsRate).HasColumnName("IsRate");
            this.Property(t => t.RoundDecimalPlaces).HasColumnName("RoundDecimalPlaces");
            this.Property(t => t.ApplyHourlyBalancing).HasColumnName("ApplyHourlyBalancing");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
