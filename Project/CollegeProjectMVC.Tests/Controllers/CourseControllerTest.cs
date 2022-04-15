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

        //course name testing
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

        //course code testing
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

        //course descirption testing
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

        //course duration testing
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

        //course availability testing
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

        //course accredation testing
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

        //course cost testing
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
