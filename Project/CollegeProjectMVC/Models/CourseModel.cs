using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProjectMVC.Models
{
    public class CourseModel
    {

        public string CourseCode { get; set; }
        public string UCASCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription{get; set;}
        public decimal CourseTotalHours { get; set; }
        public string CourseAvailability { get; set; }
        public string Accreditation { get; set; }
        public string CourseCost { get; set; }

    }
}