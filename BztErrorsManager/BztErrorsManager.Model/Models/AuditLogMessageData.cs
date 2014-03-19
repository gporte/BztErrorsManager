using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class AuditLogMessageData
    {
        public System.Guid AuditLogID { get; set; }
        public string MessageData { get; set; }
    }
}
