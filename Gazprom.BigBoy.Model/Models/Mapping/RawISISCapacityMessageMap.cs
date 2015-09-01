using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class RawISISCapacityMessageMap : EntityTypeConfiguration<RawISISCapacityMessage>
    {
        public RawISISCapacityMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.RawISISCapacityMessageId);

            // Properties
            this.Property(t => t.MessageContents)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("RawISISCapacityMessage");
            this.Property(t => t.RawISISCapacityMessageId).HasColumnName("RawISISCapacityMessageId");
            this.Property(t => t.MessageReceivedAt).HasColumnName("MessageReceivedAt");
            this.Property(t => t.MessageContents).HasColumnName("MessageContents");
        }
    }
}
