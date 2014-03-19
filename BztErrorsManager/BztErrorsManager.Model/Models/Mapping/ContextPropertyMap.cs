using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class ContextPropertyMap : EntityTypeConfiguration<ContextProperty>
    {
        public ContextPropertyMap()
        {
            // Primary Key
            this.HasKey(t => t.ContextPropertyID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(4096);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("ContextProperty");
            this.Property(t => t.ContextPropertyID).HasColumnName("ContextPropertyID");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
        }
    }
}
