using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class Message
    {
        public System.Guid MessageID { get; set; }
        public string NativeMessageID { get; set; }
        public System.Guid FaultID { get; set; }
        public string ContentType { get; set; }
        public string MessageName { get; set; }
        public string InterchangeID { get; set; }
        public string RoutingUrl { get; set; }
        public bool ResubmitAttempted { get; set; }
        public bool ResubmitSuccessful { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
        public string ActivityID { get; set; }
    }
}
