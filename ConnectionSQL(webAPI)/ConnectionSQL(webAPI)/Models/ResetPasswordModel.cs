using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectionSQL_webAPI_.Models
{
    public class ResetPasswordModel
    {   
        [DisplayName("New Password:")]
        [Required(ErrorMessage = "New password required", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DisplayName("Confirm Password:")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "New password and confirm password does not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string ResetCode { get; set; }
    }
}