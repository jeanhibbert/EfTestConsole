using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Gazprom.BigBoy.Model.Models.Mapping
{
    public class NomRenomWindowMap : EntityTypeConfiguration<NomRenomWindow>
    {
        public NomRenomWindowMap()
        {
            // Primary Key
            this.HasKey(t => t.Window);

            // Properties
            this.Property(t => t.Window)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Entry)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Exit)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("NomRenomWindows");
            this.Property(t => t.Window).HasColumnName("Window");
            this.Property(t => t.Entry).HasColumnName("Entry");
            this.Property(t => t.Exit).HasColumnName("Exit");
        }
    }
}
