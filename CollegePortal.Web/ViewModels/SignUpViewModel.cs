using CollegePortal.Web.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Web.ViewModels
{
    public class SignUpViewModel
    {
        #region Properties

        [Required]
        [Display(Name = "User Name")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initials")]
        public string MiddleInitials { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        

        [Display(Name = "Subscribed For Promotions")]
        public bool SubscribedForPromotions { get; set; }

        [Required]
        [ValidateCheckBox (ErrorMessage ="Please Accept Terms")]
        [Display(Name = "Accepted Terms Condition")]
        public bool AcceptedTermsCondition { get; set; }

        #endregion
    }
}
