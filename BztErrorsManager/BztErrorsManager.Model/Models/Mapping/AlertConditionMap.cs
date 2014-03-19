using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class AlertConditionMap : EntityTypeConfiguration<AlertCondition>
    {
        public AlertConditionMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertConditionID);

            // Properties
            this.Property(t => t.LeftSide)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RightSide)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Operator)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("AlertCondition");
            this.Property(t => t.AlertConditionID).HasColumnName("AlertConditionID");
            this.Property(t => t.AlertID).HasColumnName("AlertID");
            this.Property(t => t.LeftSide).HasColumnName("LeftSide");
            this.Property(t => t.RightSide).HasColumnName("RightSide");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.InsertedDate).HasColumnName("InsertedDate");

            // Relationships
            this.HasRequired(t => t.Alert)
                .WithMany(t => t.AlertConditions)
                .HasForeignKey(d => d.AlertID);

        }
    }
}
