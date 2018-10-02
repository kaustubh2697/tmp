using ConnectionSQL_webAPI_.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConnectionSQL_webAPI_.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Default_D(AppointmentRecords ur)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string s1 = "SELECT * FROM [dbo].[Appointment]";
            SqlCommand sqlcomm = new SqlCommand(s1);
            sqlcomm.Connection = sqlconn;
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            List<AppointmentRecords> objmodel = new List<AppointmentRecords>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    var details = new AppointmentRecords();
                   
                    details.AppointmentId = Convert.ToInt32(Request["Appointment Id"]);
                    details.UserId = Convert.ToInt32(Request["User Id"]);
                    //details.User = Convert.ToInt32(Request["User Id"]);
                    details.AppointmentDate = Convert.ToDateTime(Request["Appointment Date"]);
                    //details.AppointmentStatus = sdr["Appointment Status"].ToString();
                    details.ProblemId = Convert.ToInt32(Request["Problem Id"]);
                    //details.StartTime = Convert.ToTimeSpan(Request["Start Time"]);
                    //details.EndTime = Convert.ToTimeSpan(Request["End Time"]);
                    details.PaymentId = Convert.ToInt32(Request["Payment Id"]);
                    objmodel.Add(details);
                }
                ur.appointmentinfo = objmodel;
                sqlconn.Close();
            }
            return View("Default_D", ur);
            
        }
    }
}