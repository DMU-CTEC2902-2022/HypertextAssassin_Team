using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CollegeProjectMVC.Models
{
    public class RegCourseDB : DbContext
    {
        public DbSet<RegCourse> RegCourses { get; set; }

    }
}