using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertHistoryMap : EntityTypeConfiguration<AlertHistory>
    {
        public AlertHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertHistoryID);

            // Properties
            this.Property(t => t.AlertName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Application)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.ServiceName)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("AlertHistory");
            this.Property(t => t.AlertHistoryID).HasColumnName("AlertHistoryID");
            this.Property(t => t.AlertName).HasColumnName("AlertName");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.Application).HasColumnName("Application");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");
        }
    }
}
