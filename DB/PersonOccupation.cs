//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonOccupation
    {
        public int Id { get; set; }
        public int OccupationId { get; set; }
        public int JobTitleId { get; set; }
        public int PersonId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public Nullable<System.DateTime> Fdate { get; set; }
        public Nullable<System.DateTime> Tdate { get; set; }
        public string ReportingInformation { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Occupation Occupation { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual Person Person { get; set; }
    }
}