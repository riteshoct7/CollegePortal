using CollegePortal.Services.Interfaces;
using CollegePortal.Web.ViewModels;
using CollegePortal.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using CollegePortal.Entity.Models;
using System.Linq;

namespace CollegePortal.Web.Controllers
{
    public class AccountController : Controller
    {
        #region Properties

        private readonly IAuthenticateService authenticationService;
        private readonly IMapper mapper;

        #endregion

        #region Constructors

        public AccountController(IAuthenticateService authenticationService, IMapper mapper)
        {
            this.authenticationService = authenticationService;
            this.mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            
            if (ModelState.IsValid)
            {
                var user = authenticationService.Login(model.UserName, model.Password);
                if (user != null)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    if (user.Role.Contains("Admin"))
                    {
                        return RedirectToAction("Dashboard", "Dashboard", new { area = "Admin" });
                    }
                    else if (user.Role.Contains("User"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "User" });
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult SignUp ()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);
                user.UserName = model.Email;
                user.CreatedDate = Util.GetCurrentDateTime();
                bool result = await authenticationService.SignUp(user, model.Password);
                if (result)
                {
                    return RedirectToAction("Login");
                }
            }
            return View(model);
        }

        #endregion

    }
}
