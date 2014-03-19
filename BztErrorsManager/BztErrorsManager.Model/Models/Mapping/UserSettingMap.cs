using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BztErrorsManager.Model.Models.Mapping
{
    public class UserSettingMap : EntityTypeConfiguration<UserSetting>
    {
        public UserSettingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserName, t.SettingName, t.SettingValue });

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.SettingName)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.SettingValue)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("UserSetting");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.SettingName).HasColumnName("SettingName");
            this.Property(t => t.SettingValue).HasColumnName("SettingValue");
        }
    }
}
