using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertSubscriptionMap : EntityTypeConfiguration<AlertSubscription>
    {
        public AlertSubscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertSubscriptionID);

            // Properties
            this.Property(t => t.Subscriber)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CustomEmail)
                .HasMaxLength(255);

            this.Property(t => t.InsertedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlertSubscription");
            this.Property(t => t.AlertSubscriptionID).HasColumnName("AlertSubscriptionID");
            this.Property(t => t.AlertID).HasColumnName("AlertID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Subscriber).HasColumnName("Subscriber");
            this.Property(t => t.IsGroup).HasColumnName("IsGroup");
            this.Property(t => t.CustomEmail).HasColumnName("CustomEmail");
            this.Property(t => t.UseStartAndEndTime).HasColumnName("UseStartAndEndTime");
            this.Property(t => t.StartUTCHour).HasColumnName("StartUTCHour");
            this.Property(t => t.StartUTCMinute).HasColumnName("StartUTCMinute");
            this.Property(t => t.EndUTCHour).HasColumnName("EndUTCHour");
            this.Property(t => t.EndUTCMinute).HasColumnName("EndUTCMinute");
            this.Property(t => t.BlackOutStartDate).HasColumnName("BlackOutStartDate");
            this.Property(t => t.BlackOutEndDate).HasColumnName("BlackOutEndDate");
            this.Property(t => t.LastFired).HasColumnName("LastFired");
            this.Property(t => t.IntervalMinutes).HasColumnName("IntervalMinutes");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
            this.Property(t => t.InsertedBy).HasColumnName("InsertedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");

            // Relationships
            this.HasRequired(t => t.Alert)
                .WithMany(t => t.AlertSubscriptions)
                .HasForeignKey(d => d.AlertID);

        }
    }
}
