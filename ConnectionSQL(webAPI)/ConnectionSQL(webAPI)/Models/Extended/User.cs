using System;
using System.ComponentModel.DataAnnotations;

namespace ConnectionSQL_webAPI_.Models
{
    [MetadataType(typeof(UserMetaData))]

    public partial class User
    {

        public string ConfirmPassword { get; set; }
        public bool IsEmailVerified { get; set; }
        public string LoginErrorMessage { get; set; }

    }
    public class UserMetaData
    {


        //[Display(Name = "Email ID:")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Email Address required")]
        //[DataType(DataType.EmailAddress)]
        //public string EmailAddress { get; set; }

        //[Display(Name = "Date of birth")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }

        
        
    }
}