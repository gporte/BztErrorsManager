//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BztErrorsManager.Model.ModelBzt
{
    using System;
    using System.Collections.Generic;
    
    public partial class adm_Adapter
    {
        public adm_Adapter()
        {
            this.adm_ReceiveLocation = new HashSet<adm_ReceiveLocation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capabilities { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.Guid MgmtCLSID { get; set; }
        public Nullable<System.Guid> InboundEngineCLSID { get; set; }
        public string InboundAssemblyPath { get; set; }
        public string InboundTypeName { get; set; }
        public Nullable<System.Guid> OutboundEngineCLSID { get; set; }
        public string OutboundAssemblyPath { get; set; }
        public string OutboundTypeName { get; set; }
        public string PropertyNameSpace { get; set; }
        public string DefaultRHCfg { get; set; }
        public string DefaultTHCfg { get; set; }
    
        public virtual ICollection<adm_ReceiveLocation> adm_ReceiveLocation { get; set; }
    }
}