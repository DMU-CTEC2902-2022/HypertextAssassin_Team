//HypertextAssassin Team(https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team)
//    Members:

//    Syed - p2652259 Github(https://github.com/No3Mc) Developer/System Analyst:
//    Umar - P2630030 Github(https://github.com/itsumarsoomro) Developer

//    Victor - P2622897 Github(https://github.com/VictorTooHauAn) System Analyst
//    Pierrick - P2611172 Github(https://github.com/Riick91) System Analyst

//    Wiki:

//    Syed: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Syed's-Wiki
//    Umar: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Umar's-Wiki
//    Victor: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Victor-Too-Hau-An---Coordinator-role
//    Pierrick: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Pierrick-Njiki-An-Coordinator-role



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
        //Requests db/regcoursedb
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
        //further adds to the list so students can check their applications
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