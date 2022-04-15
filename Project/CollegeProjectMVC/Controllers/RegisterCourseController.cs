using System;
using System.Collections.Generic;
using CollegeProjectMVC.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProjectMVC.Controllers
{
    public class RegisterCourseController : Controller
    {
        // GET: RegisterCourse
        public ActionResult Index()
        {
            using (RegCourseDB db = new RegCourseDB())
            {
                return View(db.RegCourses.ToList());
            }
        }
        public ActionResult RegCourses()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegCourses(RegCourse RCourse)
        {
                using (RegCourseDB db = new RegCourseDB())
                {
                    db.RegCourses.Add(RCourse);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = RCourse.FirstName + " " + RCourse.LastName + ", Your Application for " + RCourse.CourseTitle + " has been registered Successful.";
            return View();
        }
        
    }
}