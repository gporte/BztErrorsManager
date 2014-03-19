using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertSubscriptionHistoryMap : EntityTypeConfiguration<AlertSubscriptionHistory>
    {
        public AlertSubscriptionHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertSubscriptionHistoryID);

            // Properties
            this.Property(t => t.Subscriber)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CustomEmail)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AlertSubscriptionHistory");
            this.Property(t => t.AlertSubscriptionHistoryID).HasColumnName("AlertSubscriptionHistoryID");
            this.Property(t => t.AlertHistoryID).HasColumnName("AlertHistoryID");
            this.Property(t => t.Subscriber).HasColumnName("Subscriber");
            this.Property(t => t.IsGroup).HasColumnName("IsGroup");
            this.Property(t => t.CustomEmail).HasColumnName("CustomEmail");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");

            // Relationships
            this.HasRequired(t => t.AlertHistory)
                .WithMany(t => t.AlertSubscriptionHistories)
                .HasForeignKey(d => d.AlertHistoryID);

        }
    }
}
