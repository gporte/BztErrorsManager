using System;
using System.Collections.Generic;

namespace BztErrorsManager.Model.Models
{
    public partial class Configuration
    {
        public System.Guid ConfigurationID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
