using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class FaultMap : EntityTypeConfiguration<Fault>
    {
        public FaultMap()
        {
            // Primary Key
            this.HasKey(t => t.FaultID);

            // Properties
            this.Property(t => t.NativeMessageID)
                .HasMaxLength(38);

            this.Property(t => t.ActivityID)
                .HasMaxLength(38);

            this.Property(t => t.Application)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Description)
                .HasMaxLength(4096);

            this.Property(t => t.ErrorType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FailureCategory)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.FaultCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FaultDescription)
                .HasMaxLength(4096);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ServiceInstanceID)
                .IsRequired()
                .HasMaxLength(38);

            this.Property(t => t.ServiceName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.FaultGenerator)
                .HasMaxLength(50);

            this.Property(t => t.MachineName)
                .HasMaxLength(256);

            this.Property(t => t.ExceptionMessage)
                .IsRequired()
                .HasMaxLength(4096);

            this.Property(t => t.ExceptionType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ExceptionSource)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ExceptionTargetSite)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ExceptionStackTrace)
                .IsRequired()
                .HasMaxLength(4096);

            this.Property(t => t.InnerExceptionMessage)
                .IsRequired()
                .HasMaxLength(4096);

            // Table & Column Mappings
            this.ToTable("Fault");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.NativeMessageID).HasColumnName("NativeMessageID");
            this.Property(t => t.ActivityID).HasColumnName("ActivityID");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ErrorType).HasColumnName("ErrorType");
            this.Property(t => t.FailureCategory).HasColumnName("FailureCategory");
            this.Property(t => t.FaultCode).HasColumnName("FaultCode");
            this.Property(t => t.FaultDescription).HasColumnName("FaultDescription");
            this.Property(t => t.FaultSeverity).HasColumnName("FaultSeverity");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.ServiceInstanceID).HasColumnName("ServiceInstanceID");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.FaultGenerator).HasColumnName("FaultGenerator");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.ExceptionMessage).HasColumnName("ExceptionMessage");
            this.Property(t => t.ExceptionType).HasColumnName("ExceptionType");
            this.Property(t => t.ExceptionSource).HasColumnName("ExceptionSource");
            this.Property(t => t.ExceptionTargetSite).HasColumnName("ExceptionTargetSite");
            this.Property(t => t.ExceptionStackTrace).HasColumnName("ExceptionStackTrace");
            this.Property(t => t.InnerExceptionMessage).HasColumnName("InnerExceptionMessage");
            this.Property(t => t.InsertMessagesFlag).HasColumnName("InsertMessagesFlag");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
            this.Property(t => t.Treated).HasColumnName("Treated");
        }
    }
}
