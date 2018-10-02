using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConnectionSQL_webAPI_.Models
{
    public class UserRecords
    {
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "This field is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public List<UserRecords> userinfo { get; set; }
    }
}