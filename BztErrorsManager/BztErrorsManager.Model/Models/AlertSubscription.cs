using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AlertSubscription
    {
        public System.Guid AlertSubscriptionID { get; set; }
        public System.Guid AlertID { get; set; }
        public bool Active { get; set; }
        public string Subscriber { get; set; }
        public bool IsGroup { get; set; }
        public string CustomEmail { get; set; }
        public bool UseStartAndEndTime { get; set; }
        public Nullable<byte> StartUTCHour { get; set; }
        public Nullable<byte> StartUTCMinute { get; set; }
        public Nullable<byte> EndUTCHour { get; set; }
        public Nullable<byte> EndUTCMinute { get; set; }
        public Nullable<System.DateTime> BlackOutStartDate { get; set; }
        public Nullable<System.DateTime> BlackOutEndDate { get; set; }
        public Nullable<System.DateTime> LastFired { get; set; }
        public short IntervalMinutes { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public string InsertedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual Alert Alert { get; set; }
    }
}
