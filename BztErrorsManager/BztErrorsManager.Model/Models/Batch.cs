using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class Batch
    {
        public System.Guid BatchID { get; set; }
        public System.DateTime StartDatetime { get; set; }
        public Nullable<System.DateTime> EndDatetime { get; set; }
        public string ErrorMessage { get; set; }
    }
}
