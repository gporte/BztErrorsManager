using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AlertCondition
    {
        public System.Guid AlertConditionID { get; set; }
        public System.Guid AlertID { get; set; }
        public string LeftSide { get; set; }
        public string RightSide { get; set; }
        public string Operator { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public virtual Alert Alert { get; set; }
    }
}
