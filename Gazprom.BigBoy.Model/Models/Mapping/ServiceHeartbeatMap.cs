using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class ServiceHeartbeatMap : EntityTypeConfiguration<ServiceHeartbeat>
    {
        public ServiceHeartbeatMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceName);

            // Properties
            this.Property(t => t.ServiceName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ServiceHeartbeat");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.Heartbeat).HasColumnName("Heartbeat");
            this.Property(t => t.LastRun).HasColumnName("LastRun");
        }
    }
}
