using CollegePortal.Services.Interfaces;
using CollegePortal.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CollegePortal.Web.Controllers
{
    public class AccountController : Controller
    {
        #region Properties

        private readonly IAuthenticationService authenticationService; 

        #endregion

        #region Constructors

        public AccountController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        #endregion

        #region Methods

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel model)
        {
            return View();
        }

        #endregion

    }
}
