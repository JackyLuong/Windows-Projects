//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayRollWebForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attraction
    {
        public int TripID { get; set; }
        public int SeqNo { get; set; }
        public string Description { get; set; }
    
        public virtual Trip Trip { get; set; }
    }
}
