//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VLURecruit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Times_Recruitment
    {
        public int Time_id { get; set; }
        public int Recruitment_id { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
    
        public virtual Recruitment Recruitment { get; set; }
        public virtual Time Time { get; set; }
    }
}