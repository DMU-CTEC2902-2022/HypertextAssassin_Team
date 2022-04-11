using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using CollegeProjectMVC.Controllers;
using CollegeProjectMVC.Models;

namespace CollegeProjectMVC.Tests.Controllers
{
    [TestClass]
    public class CourseControllerTest
    {
     
        [TestMethod]

        public void CourseName()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("Computer Science", result.CourseTitle);
        }
    }
}
