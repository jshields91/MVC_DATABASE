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
    
    public partial class RFIINVITE
    {
        public int PRIMARYKEY { get; set; }
        public int RFIID { get; set; }
        public string Id { get; set; }
        public string GHX_PATH { get; set; }
        public string CATALOGPATH { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual RFI RFI { get; set; }
    }
}
