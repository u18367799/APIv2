//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrayonKidsAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Applications = new HashSet<Application>();
            this.ReportCards = new HashSet<ReportCard>();
            this.School_Term = new HashSet<School_Term>();
        }
    
        public int Student_ID { get; set; }
        public Nullable<int> Parent_Guardian_ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_Surname { get; set; }
        public Nullable<int> Student_Grade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }
        public virtual Parent_Guardian Parent_Guardian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportCard> ReportCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<School_Term> School_Term { get; set; }
    }
}
