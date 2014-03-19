using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AlertEmail
    {
        public System.Guid AlertEmailID { get; set; }
        public System.Guid AlertSubscriptionHistoryID { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool Sent { get; set; }
        public System.Guid BatchID { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public string Category { get; set; }
    }
}
