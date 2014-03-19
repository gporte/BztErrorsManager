using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AuditLog
    {
        public System.Guid AuditLogID { get; set; }
        public System.Guid ActionTypeID { get; set; }
        public System.Guid MessageID { get; set; }
        public string NativeMessageID { get; set; }
        public string ContentType { get; set; }
        public string MessageName { get; set; }
        public Nullable<System.Guid> FaultID { get; set; }
        public string NativeFaultID { get; set; }
        public string Application { get; set; }
        public string ServiceName { get; set; }
        public string ResubmitURL { get; set; }
        public string ResubmitCode { get; set; }
        public string ResubmitMessage { get; set; }
        public System.DateTime AuditDate { get; set; }
        public string AuditUserName { get; set; }
    }
}
