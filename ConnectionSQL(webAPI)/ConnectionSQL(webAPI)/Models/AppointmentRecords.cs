using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConnectionSQL_webAPI_.Models
{
    public class AppointmentRecords
    {
        public int AppointmentId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string AppointmentStatus { get; set; }
        public Nullable<int> ProblemId { get; set; }
        public Nullable<int> PaymentId { get; set; }

        public List<AppointmentRecords> appointmentinfo { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}