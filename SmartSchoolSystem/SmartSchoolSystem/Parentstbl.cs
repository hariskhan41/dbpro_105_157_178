//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parentstbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parentstbl()
        {
            this.Leavestbls = new HashSet<Leavestbl>();
            this.ParentStudenttbls = new HashSet<ParentStudenttbl>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PrntPassword { get; set; }
        public string CNIC { get; set; }
        public int ApprovalStatusId { get; set; }
        public string MailAddress { get; set; }
    
        public virtual ApprovalStatustbl ApprovalStatustbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leavestbl> Leavestbls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParentStudenttbl> ParentStudenttbls { get; set; }
    }
}
