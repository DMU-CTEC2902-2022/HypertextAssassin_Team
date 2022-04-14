using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProjectMVC.Models
{
    public class CourseModel
    {
        //Course model for Computer Science course
        public string CourseCode { get; set; }
        public string UCASCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription{get; set;}
        public decimal CourseTotalHours { get; set; }
        public string CourseAvailability { get; set; }
        public string Accreditation { get; set; }
        public string CourseCost { get; set; }

        //Course model for Software engineer course
        public string CourseCode2 { get; set; }
        public string UCASCode2 { get; set; }
        public string CourseTitle2 { get; set; }
        public string CourseDescription2 { get; set; }
        public decimal CourseTotalHours2 { get; set; }
        public string CourseAvailability2 { get; set; }
        public string Accreditation2 { get; set; }
        public string CourseCost2 { get; set; }

        //Course model for Cyber Security course
        public string CourseCode3 { get; set; }
        public string UCASCode3 { get; set; }
        public string CourseTitle3 { get; set; }
        public string CourseDescription3 { get; set; }
        public decimal CourseTotalHours3 { get; set; }
        public string CourseAvailability3 { get; set; }
        public string Accreditation3 { get; set; }
        public string CourseCost3 { get; set; }

    }

}