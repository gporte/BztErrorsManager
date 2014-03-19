using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class ActionTypeMap : EntityTypeConfiguration<ActionType>
    {
        public ActionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionTypeID);

            // Properties
            this.Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ActionType");
            this.Property(t => t.ActionTypeID).HasColumnName("ActionTypeID");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
        }
    }
}
