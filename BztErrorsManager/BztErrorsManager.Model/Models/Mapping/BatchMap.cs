using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class BatchMap : EntityTypeConfiguration<Batch>
    {
        public BatchMap()
        {
            // Primary Key
            this.HasKey(t => t.BatchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Batch");
            this.Property(t => t.BatchID).HasColumnName("BatchID");
            this.Property(t => t.StartDatetime).HasColumnName("StartDatetime");
            this.Property(t => t.EndDatetime).HasColumnName("EndDatetime");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
        }
    }
}
