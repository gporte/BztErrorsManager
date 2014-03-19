using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AlertSubscriptionHistory
    {
        public System.Guid AlertSubscriptionHistoryID { get; set; }
        public System.Guid AlertHistoryID { get; set; }
        public string Subscriber { get; set; }
        public bool IsGroup { get; set; }
        public string CustomEmail { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public virtual AlertHistory AlertHistory { get; set; }
    }
}
