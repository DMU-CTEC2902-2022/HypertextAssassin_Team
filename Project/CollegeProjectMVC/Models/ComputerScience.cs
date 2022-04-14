using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeProjectMVC.Models
{
    public class ComputerScience
    {
        //module model for Computer Science course
        public string ModuleCode { get; set; }
        public string ModuleTitle { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleContents { get; set; }
        public string StaffMembers { get; set; }
    }
}