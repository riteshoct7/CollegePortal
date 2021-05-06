using CollegePortal.Services.Interfaces;
using CollegePortal.Web.ViewModels;
using CollegePortal.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using CollegePortal.Entity.Models;

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
