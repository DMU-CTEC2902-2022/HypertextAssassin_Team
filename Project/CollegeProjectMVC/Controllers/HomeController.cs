using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "University description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Departments:";

            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Courses contact page.";

            return View();
        }
    }
}