//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectionSQL_webAPI_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> QuestionId1 { get; set; }
        public string Answer1 { get; set; }
        public Nullable<int> QuestionId2 { get; set; }
        public string Answer2 { get; set; }
        public Nullable<int> QuestionId3 { get; set; }
        public string Answer3 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual SecurityQuestion SecurityQuestion { get; set; }
        public virtual SecurityQuestion SecurityQuestion1 { get; set; }
        public virtual SecurityQuestion SecurityQuestion2 { get; set; }
        public virtual User User { get; set; }
    }
}
