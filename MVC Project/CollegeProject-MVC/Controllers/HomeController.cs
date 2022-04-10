using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject_MVC.Controllers
{
    public class HomeController : Controller
    {
        //index method
        public ActionResult Index()
        {
            return View();
        }
        //about method
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //contact method
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}