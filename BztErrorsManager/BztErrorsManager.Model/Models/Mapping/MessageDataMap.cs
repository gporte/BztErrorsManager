using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class MessageDataMap : EntityTypeConfiguration<MessageData>
    {
        public MessageDataMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.MessageData1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("MessageData");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.MessageData1).HasColumnName("MessageData");
        }
    }
}
