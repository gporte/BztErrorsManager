using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AuditLogMessageDataMap : EntityTypeConfiguration<AuditLogMessageData>
    {
        public AuditLogMessageDataMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditLogID);

            // Properties
            this.Property(t => t.MessageData)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("AuditLogMessageData");
            this.Property(t => t.AuditLogID).HasColumnName("AuditLogID");
            this.Property(t => t.MessageData).HasColumnName("MessageData");
        }
    }
}
