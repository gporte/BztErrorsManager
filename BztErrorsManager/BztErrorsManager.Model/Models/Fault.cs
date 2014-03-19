using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class Fault
    {
        public System.Guid FaultID { get; set; }
        public string NativeMessageID { get; set; }
        public string ActivityID { get; set; }
        public string Application { get; set; }
        public string Description { get; set; }
        public string ErrorType { get; set; }
        public string FailureCategory { get; set; }
        public string FaultCode { get; set; }
        public string FaultDescription { get; set; }
        public Nullable<int> FaultSeverity { get; set; }
        public string Scope { get; set; }
        public string ServiceInstanceID { get; set; }
        public string ServiceName { get; set; }
        public string FaultGenerator { get; set; }
        public string MachineName { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionSource { get; set; }
        public string ExceptionTargetSite { get; set; }
        public string ExceptionStackTrace { get; set; }
        public string InnerExceptionMessage { get; set; }
        public Nullable<bool> InsertMessagesFlag { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public Nullable<bool> Treated { get; set; }
    }
}
