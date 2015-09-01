using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class GasTradeAdjustProfileMap : EntityTypeConfiguration<GasTradeAdjustProfile>
    {
        public GasTradeAdjustProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.GasTradeAdjustProfileId);

            // Properties
            this.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("GasTradeAdjustProfile");
            this.Property(t => t.GasTradeAdjustProfileId).HasColumnName("GasTradeAdjustProfileId");
            this.Property(t => t.GasTradePositionAdjustId).HasColumnName("GasTradePositionAdjustId");
            this.Property(t => t.StartDateUTC).HasColumnName("StartDateUTC");
            this.Property(t => t.EndDateUTC).HasColumnName("EndDateUTC");
            this.Property(t => t.Volume).HasColumnName("Volume");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");

            // Relationships
            this.HasRequired(t => t.GasTradePositionAdjust)
                .WithMany(t => t.GasTradeAdjustProfiles)
                .HasForeignKey(d => d.GasTradePositionAdjustId);

        }
    }
}
