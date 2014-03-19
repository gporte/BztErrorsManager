using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class ContextProperty
    {
        public System.Guid ContextPropertyID { get; set; }
        public System.Guid MessageID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public System.DateTime InsertedDate { get; set; }
    }
}
