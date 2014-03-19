using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AuditLogMap : EntityTypeConfiguration<AuditLog>
    {
        public AuditLogMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditLogID);

            // Properties
            this.Property(t => t.NativeMessageID)
                .HasMaxLength(38);

            this.Property(t => t.ContentType)
                .HasMaxLength(50);

            this.Property(t => t.MessageName)
                .HasMaxLength(50);

            this.Property(t => t.NativeFaultID)
                .HasMaxLength(38);

            this.Property(t => t.Application)
                .HasMaxLength(256);

            this.Property(t => t.ServiceName)
                .HasMaxLength(256);

            this.Property(t => t.ResubmitURL)
                .HasMaxLength(512);

            this.Property(t => t.ResubmitCode)
                .HasMaxLength(3);

            this.Property(t => t.ResubmitMessage)
                .HasMaxLength(50);

            this.Property(t => t.AuditUserName)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("AuditLog");
            this.Property(t => t.AuditLogID).HasColumnName("AuditLogID");
            this.Property(t => t.ActionTypeID).HasColumnName("ActionTypeID");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.NativeMessageID).HasColumnName("NativeMessageID");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.MessageName).HasColumnName("MessageName");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.NativeFaultID).HasColumnName("NativeFaultID");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.ResubmitURL).HasColumnName("ResubmitURL");
            this.Property(t => t.ResubmitCode).HasColumnName("ResubmitCode");
            this.Property(t => t.ResubmitMessage).HasColumnName("ResubmitMessage");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.AuditUserName).HasColumnName("AuditUserName");
        }
    }
}
