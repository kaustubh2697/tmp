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
    
    public partial class DoctorInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorInfo()
        {
            this.Appointments = new HashSet<Appointment>();
            this.DoctorBelongsHospitals = new HashSet<DoctorBelongsHospital>();
        }
    
        public int DoctorId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Qualification { get; set; }
        public string Year { get; set; }
        public string InstitutionName { get; set; }
        public string Specality { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorBelongsHospital> DoctorBelongsHospitals { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual User User { get; set; }
    }
}
