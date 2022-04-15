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