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
    
    public partial class StudentClasstbl
    {
        public int Id { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Classtbl Classtbl { get; set; }
        public virtual Studentstbl Studentstbl { get; set; }
    }
}