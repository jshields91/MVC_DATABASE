//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_DATABASE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENDOR
    {
        public string Id { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string ORGANIZATION { get; set; }
        public bool SANCTIONED { get; set; }
        public string VENDSTATUS { get; set; }
        public string LOG { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
