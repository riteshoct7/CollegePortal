using Microsoft.AspNetCore.Mvc;

namespace CollegePortal.Web.Controllers
{
    public class Accountontroller : Controller
    {

        #region Constructors

        public Accountontroller()
        {

        }

        #endregion

        #region Methods

        public IActionResult Index()
        {
            return View();
        } 

        #endregion

    }
}
