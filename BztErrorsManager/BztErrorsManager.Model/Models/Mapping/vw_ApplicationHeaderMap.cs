using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class vw_ApplicationHeaderMap : EntityTypeConfiguration<vw_ApplicationHeader>
    {
        public vw_ApplicationHeaderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MessageID, t.Value });

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(4096);

            // Table & Column Mappings
            this.ToTable("vw_ApplicationHeader");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
