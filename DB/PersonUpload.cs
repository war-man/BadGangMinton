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
    
    public partial class PersonUpload
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int UploadTypeId { get; set; }
        public int PersonId { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual UploadType UploadType { get; set; }
        public virtual Person Person { get; set; }
    }
}