using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class vw_FaultsByAppheader
    {
        public System.Guid FaultID { get; set; }
        public string Application { get; set; }
        public string ErrorType { get; set; }
        public string FailureCategory { get; set; }
        public string FaultCode { get; set; }
        public string FaultGenerator { get; set; }
        public Nullable<int> FaultSeverity { get; set; }
        public string Scope { get; set; }
        public string ServiceName { get; set; }
        public string MessageData { get; set; }
        public Nullable<bool> InsertMessagesFlag { get; set; }
        public string MachineName { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string BusinessApplication { get; set; }
        public Nullable<bool> Treated { get; set; }
        public string FaultDescription { get; set; }
    }
}
