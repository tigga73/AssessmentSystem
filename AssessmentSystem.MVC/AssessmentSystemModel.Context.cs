﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssessmentSystemEntities : DbContext
    {
        public AssessmentSystemEntities()
            : base("name=AssessmentSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnarie> Questionnaries { get; set; }
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAssessment> StudentAssessments { get; set; }
        public virtual DbSet<StudentAssessmentAnswer> StudentAssessmentAnswers { get; set; }
        public virtual DbSet<StudentAssessmentPerformance> StudentAssessmentPerformances { get; set; }
    }
}
