using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class KeyPerformanceIndicatorMap : EntityTypeConfiguration<KeyPerformanceIndicator>
    {
        public KeyPerformanceIndicatorMap()
        {
            // Primary Key
            this.HasKey(t => t.KPI_ID);

            // Properties
            this.Property(t => t.KeyPerformanceIndicator1)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.User)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Machine)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("KeyPerformanceIndicators");
            this.Property(t => t.KPI_ID).HasColumnName("KPI_ID");
            this.Property(t => t.KeyPerformanceIndicator1).HasColumnName("KeyPerformanceIndicator");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.User).HasColumnName("User");
            this.Property(t => t.Machine).HasColumnName("Machine");
            this.Property(t => t.ElapsedMilliseconds).HasColumnName("ElapsedMilliseconds");
            this.Property(t => t.ElapsedTicks).HasColumnName("ElapsedTicks");
        }
    }
}
