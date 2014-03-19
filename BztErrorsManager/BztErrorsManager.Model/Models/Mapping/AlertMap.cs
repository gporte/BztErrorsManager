using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertMap : EntityTypeConfiguration<Alert>
    {
        public AlertMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ConditionsString)
                .IsRequired();

            this.Property(t => t.InsertedBy)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Alert");
            this.Property(t => t.AlertID).HasColumnName("AlertID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ConditionsString).HasColumnName("ConditionsString");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
            this.Property(t => t.InsertedBy).HasColumnName("InsertedBy");
        }
    }
}
