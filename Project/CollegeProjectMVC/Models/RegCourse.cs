/*HypertextAssassin Team(https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team)
    Members:

    Syed-p2652259 Github(https://github.com/No3Mc) Developer/System Analyst:
    Umar-P2630030 Github(https://github.com/itsumarsoomro) Developer

    Victor-P2622897 Github(https://github.com/VictorTooHauAn) System Analyst
    Pierrick-P2611172 Github(https://github.com/Riick91) System Analyst

    Wiki:

    Syed: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Syed's-Wiki
    Umar: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Umar's-Wiki
    Victor: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Victor-Too-Hau-An---Coordinator-role
    Pierrick: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Pierrick-Njiki-An-Coordinator-role */



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