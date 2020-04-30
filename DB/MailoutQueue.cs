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
    
    public partial class MailoutQueue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MailoutQueue()
        {
            this.MailoutQueueParameterValue = new HashSet<MailoutQueueParameterValue>();
            this.MailoutTracker = new HashSet<MailoutTracker>();
        }
    
        public int Id { get; set; }
        public short Status { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string EmailAddress { get; set; }
        public string HtmlBody { get; set; }
        public int PersonId { get; set; }
        public int MailoutTypeId { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual MailoutType MailoutType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailoutQueueParameterValue> MailoutQueueParameterValue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailoutTracker> MailoutTracker { get; set; }
    }
}
