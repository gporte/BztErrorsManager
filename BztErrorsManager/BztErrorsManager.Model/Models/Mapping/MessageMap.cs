using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.NativeMessageID)
                .HasMaxLength(38);

            this.Property(t => t.ContentType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MessageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InterchangeID)
                .HasMaxLength(38);

            this.Property(t => t.RoutingUrl)
                .HasMaxLength(512);

            this.Property(t => t.ActivityID)
                .HasMaxLength(38);

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.NativeMessageID).HasColumnName("NativeMessageID");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.MessageName).HasColumnName("MessageName");
            this.Property(t => t.InterchangeID).HasColumnName("InterchangeID");
            this.Property(t => t.RoutingUrl).HasColumnName("RoutingUrl");
            this.Property(t => t.ResubmitAttempted).HasColumnName("ResubmitAttempted");
            this.Property(t => t.ResubmitSuccessful).HasColumnName("ResubmitSuccessful");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
            this.Property(t => t.ActivityID).HasColumnName("ActivityID");
        }
    }
}
