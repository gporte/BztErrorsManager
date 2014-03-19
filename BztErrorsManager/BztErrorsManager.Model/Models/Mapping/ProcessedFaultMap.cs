using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class ProcessedFaultMap : EntityTypeConfiguration<ProcessedFault>
    {
        public ProcessedFaultMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessedFaultID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProcessedFault");
            this.Property(t => t.ProcessedFaultID).HasColumnName("ProcessedFaultID");
        }
    }
}
