using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Web.ViewModels
{
    public class SignUpViewModel
    {
        #region Properties

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initials")]
        public string MiddleInitials { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Subscribed For Promotions")]
        public bool SubscribedForPromotions { get; set; }

        [Required]
        [Display(Name = "Accepted Terms Condition")]
        public bool AcceptedTermsCondition { get; set; }

        #endregion
    }
}
