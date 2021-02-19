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
    
    public partial class PersonAddress
    {
        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public int CountryId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string State { get; set; }
        public string Landmark { get; set; }
        public int PersonId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    
        public virtual AddressType AddressType { get; set; }
        public virtual Country Country { get; set; }
        public virtual Person Person { get; set; }
    }
}