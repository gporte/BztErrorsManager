using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertEmailMap : EntityTypeConfiguration<AlertEmail>
    {
        public AlertEmailMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertEmailID);

            // Properties
            this.Property(t => t.To)
                .HasMaxLength(256);

            this.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(1024);

            this.Property(t => t.Body)
                .IsRequired();

            this.Property(t => t.Category)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlertEmail");
            this.Property(t => t.AlertEmailID).HasColumnName("AlertEmailID");
            this.Property(t => t.AlertSubscriptionHistoryID).HasColumnName("AlertSubscriptionHistoryID");
            this.Property(t => t.To).HasColumnName("To");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.Sent).HasColumnName("Sent");
            this.Property(t => t.BatchID).HasColumnName("BatchID");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
            this.Property(t => t.Category).HasColumnName("Category");
        }
    }
}
