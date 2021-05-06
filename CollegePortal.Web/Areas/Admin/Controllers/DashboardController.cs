using Microsoft.AspNetCore.Mvc;

namespace CollegePortal.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        #region Constructors
        public DashboardController()
        {

        }
        #endregion

        #region Methods

        public IActionResult Dashboard()
        {
            return View();
        } 

        #endregion

    }
}
