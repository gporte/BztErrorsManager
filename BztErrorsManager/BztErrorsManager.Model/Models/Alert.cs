using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class Alert
    {
        public Alert()
        {
            this.AlertConditions = new List<AlertCondition>();
            this.AlertSubscriptions = new List<AlertSubscription>();
        }

        public System.Guid AlertID { get; set; }
        public string Name { get; set; }
        public string ConditionsString { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public string InsertedBy { get; set; }
        public virtual ICollection<AlertCondition> AlertConditions { get; set; }
        public virtual ICollection<AlertSubscription> AlertSubscriptions { get; set; }
    }
}
