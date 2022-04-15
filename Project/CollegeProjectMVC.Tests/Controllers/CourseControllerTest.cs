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
        [TestMethod]
        public void CourseCode()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("D16", result.CourseCode);
        }
        [TestMethod]
        public void CourseDescription()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("Computer science (CS) is the study of computers and algorithmic processes, including their principles, their hardware and software designs, their applications, and their impact on society.", result.CourseDescription);
        }
        [TestMethod]
        public void CourseDuration()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual(390, result.CourseTotalHours);
        }
        [TestMethod]
        public void CourseAvailability()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("Available", result.CourseAvailability);
        }
        [TestMethod]
        public void CourseAccreditation()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("BCS", result.Accreditation);
        }
        [TestMethod]
        public void CourseCost()
        {
            // Arrange
            CourseController controller = new CourseController();

            //Act
            ViewResult viewResult = controller.Course();
            CourseModel result = viewResult.Model as CourseModel;

            // Assert
            Assert.AreEqual("16,250$", result.CourseCost);
        }
    }
}
