using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CollegeProjectMVC.Models
{
    public class RegCourse
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }


        [Required(ErrorMessage = "PhoneNo is required")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "CourseCode is required")]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "UCASCode is required")]
        public string UCASCode { get; set; }

        [Required(ErrorMessage = "CourseTitle is required")]
        public string CourseTitle { get; set; }
    }
}