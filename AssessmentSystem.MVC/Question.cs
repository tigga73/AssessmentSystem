//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssessmentSystem.MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.QuestionOptions = new HashSet<QuestionOption>();
        }
    
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public int ProfessorId { get; set; }
        public int QuestionnarieId { get; set; }
    
        public virtual Professor Professor { get; set; }
        public virtual Questionnarie Questionnarie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
