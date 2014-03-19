using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AlertHistory
    {
        public AlertHistory()
        {
            this.AlertSubscriptionHistories = new List<AlertSubscriptionHistory>();
        }

        public System.Guid AlertHistoryID { get; set; }
        public string AlertName { get; set; }
        public System.Guid FaultID { get; set; }
        public string Application { get; set; }
        public string ServiceName { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public virtual ICollection<AlertSubscriptionHistory> AlertSubscriptionHistories { get; set; }
    }
}
