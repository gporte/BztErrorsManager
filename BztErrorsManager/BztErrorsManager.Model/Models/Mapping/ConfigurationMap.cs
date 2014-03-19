using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class ConfigurationMap : EntityTypeConfiguration<Configuration>
    {
        public ConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Value)
                .HasMaxLength(256);

            this.Property(t => t.Description)
                .HasMaxLength(1024);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Configuration");
            this.Property(t => t.ConfigurationID).HasColumnName("ConfigurationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
