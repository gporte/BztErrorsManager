using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class vw_FaultsByAppheaderMap : EntityTypeConfiguration<vw_FaultsByAppheader>
    {
        public vw_FaultsByAppheaderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FaultID, t.Application, t.ErrorType, t.FailureCategory, t.FaultCode, t.Scope, t.ServiceName, t.MessageData });

            // Properties
            this.Property(t => t.Application)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ErrorType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FailureCategory)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.FaultCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FaultGenerator)
                .HasMaxLength(50);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ServiceName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.MessageData)
                .IsRequired();

            this.Property(t => t.MachineName)
                .HasMaxLength(256);

            this.Property(t => t.FaultDescription)
                .HasMaxLength(4096);

            // Table & Column Mappings
            this.ToTable("vw_FaultsByAppheader");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.ErrorType).HasColumnName("ErrorType");
            this.Property(t => t.FailureCategory).HasColumnName("FailureCategory");
            this.Property(t => t.FaultCode).HasColumnName("FaultCode");
            this.Property(t => t.FaultGenerator).HasColumnName("FaultGenerator");
            this.Property(t => t.FaultSeverity).HasColumnName("FaultSeverity");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.MessageData).HasColumnName("MessageData");
            this.Property(t => t.InsertMessagesFlag).HasColumnName("InsertMessagesFlag");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.BusinessApplication).HasColumnName("BusinessApplication");
            this.Property(t => t.Treated).HasColumnName("Treated");
            this.Property(t => t.FaultDescription).HasColumnName("FaultDescription");
        }
    }
}
