using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class SendTypeMap : EntityTypeConfiguration<SendType>
    {
        public SendTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SendTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SendType");
            this.Property(t => t.SendTypeId).HasColumnName("SendTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
