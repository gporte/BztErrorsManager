using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BztErrorsManager.Model.Models.Mapping;

namespace BztErrorsManager.Model.Models
{
    public partial class EsbExceptionDbContext : DbContext
    {
        static EsbExceptionDbContext()
        {
            Database.SetInitializer<EsbExceptionDbContext>(null);
        }

        public EsbExceptionDbContext()
            : base("Name=EsbExceptionDbContext")
        {
        }

        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertCondition> AlertConditions { get; set; }
        public DbSet<AlertEmail> AlertEmails { get; set; }
        public DbSet<AlertHistory> AlertHistories { get; set; }
        public DbSet<AlertSubscription> AlertSubscriptions { get; set; }
        public DbSet<AlertSubscriptionHistory> AlertSubscriptionHistories { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<AuditLogMessageData> AuditLogMessageDatas { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<ContextProperty> ContextProperties { get; set; }
        public DbSet<Fault> Faults { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageData> MessageDatas { get; set; }
        public DbSet<ProcessedFault> ProcessedFaults { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<vw_AggregatedFaults> vw_AggregatedFaults { get; set; }
        public DbSet<vw_ApplicationHeader> vw_ApplicationHeader { get; set; }
        public DbSet<vw_FaultsByAppheader> vw_FaultsByAppheader { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActionTypeMap());
            modelBuilder.Configurations.Add(new AlertMap());
            modelBuilder.Configurations.Add(new AlertConditionMap());
            modelBuilder.Configurations.Add(new AlertEmailMap());
            modelBuilder.Configurations.Add(new AlertHistoryMap());
            modelBuilder.Configurations.Add(new AlertSubscriptionMap());
            modelBuilder.Configurations.Add(new AlertSubscriptionHistoryMap());
            modelBuilder.Configurations.Add(new AuditLogMap());
            modelBuilder.Configurations.Add(new AuditLogMessageDataMap());
            modelBuilder.Configurations.Add(new BatchMap());
            modelBuilder.Configurations.Add(new ConfigurationMap());
            modelBuilder.Configurations.Add(new ContextPropertyMap());
            modelBuilder.Configurations.Add(new FaultMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new MessageDataMap());
            modelBuilder.Configurations.Add(new ProcessedFaultMap());
            modelBuilder.Configurations.Add(new UserSettingMap());
            modelBuilder.Configurations.Add(new vw_AggregatedFaultsMap());
            modelBuilder.Configurations.Add(new vw_ApplicationHeaderMap());
            modelBuilder.Configurations.Add(new vw_FaultsByAppheaderMap());
        }
    }
}
