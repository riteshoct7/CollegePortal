using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Web.ViewModels
{
    public class LoginViewModel
    {
        #region Properties

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } 

        #endregion

    }
}
