using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class vw_AggregatedFaults
    {
        public Nullable<int> FaultCount { get; set; }
        public string Application { get; set; }
        public string ServiceName { get; set; }
        public string ErrorType { get; set; }
        public string ExceptionType { get; set; }
        public string FaultCode { get; set; }
        public string FailureCategory { get; set; }
        public Nullable<int> FaultSeverity { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> Hour { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<System.DateTime> TrueDateTime { get; set; }
    }
}
