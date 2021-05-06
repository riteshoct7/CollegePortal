using CollegePortal.Entity.Models;
using CollegePortal.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegePortal.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {

        #region Properties

        private readonly IStudentService studentService;

        #endregion

        #region Constructors

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        } 

        #endregion
        public IActionResult List()
        {
            IEnumerable<Student> lstStudents = studentService.GetAllStudents();
            return View();
        }
    }
}
