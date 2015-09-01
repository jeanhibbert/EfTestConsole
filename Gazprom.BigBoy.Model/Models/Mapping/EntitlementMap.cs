using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class EntitlementMap : EntityTypeConfiguration<Entitlement>
    {
        public EntitlementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CapacityDay, t.Location, t.IsEntry });

            // Properties
            this.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Entitlements");
            this.Property(t => t.CapacityDay).HasColumnName("CapacityDay");
            this.Property(t => t.NetCapacity).HasColumnName("NetCapacity");
            this.Property(t => t.NetFirmCapacity).HasColumnName("NetFirmCapacity");
            this.Property(t => t.NetInterruptibleCapacity).HasColumnName("NetInterruptibleCapacity");
            this.Property(t => t.NetScaledInterruptibleCapacity).HasColumnName("NetScaledInterruptibleCapacity");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.RecordNumber).HasColumnName("RecordNumber");
            this.Property(t => t.IsEntry).HasColumnName("IsEntry");
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");
        }
    }
}
