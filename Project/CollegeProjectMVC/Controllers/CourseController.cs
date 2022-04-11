using CollegeProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ViewResult Course()
        {
            CourseModel courseModel = new CourseModel();
            courseModel.CourseCode = "D26";
            courseModel.UCASCode = "D226";
            courseModel.CourseTitle = "Computer Science";
            courseModel.CourseDescription = "ssafdasfasf";
            courseModel.CourseTotalHours = 190;
            courseModel.CourseAvailability = "Available";
            courseModel.Accreditation = "BCS";
            courseModel.CourseCost = "14,250$";


            return View(courseModel);
        }
    }
}