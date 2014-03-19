using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class vw_AggregatedFaultsMap : EntityTypeConfiguration<vw_AggregatedFaults>
    {
        public vw_AggregatedFaultsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Application, t.ServiceName, t.ErrorType, t.ExceptionType, t.FaultCode, t.FailureCategory });

            // Properties
            this.Property(t => t.Application)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ServiceName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ErrorType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ExceptionType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FaultCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FailureCategory)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("vw_AggregatedFaults");
            this.Property(t => t.FaultCount).HasColumnName("FaultCount");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.ErrorType).HasColumnName("ErrorType");
            this.Property(t => t.ExceptionType).HasColumnName("ExceptionType");
            this.Property(t => t.FaultCode).HasColumnName("FaultCode");
            this.Property(t => t.FailureCategory).HasColumnName("FailureCategory");
            this.Property(t => t.FaultSeverity).HasColumnName("FaultSeverity");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.Day).HasColumnName("Day");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.TrueDateTime).HasColumnName("TrueDateTime");
        }
    }
}
