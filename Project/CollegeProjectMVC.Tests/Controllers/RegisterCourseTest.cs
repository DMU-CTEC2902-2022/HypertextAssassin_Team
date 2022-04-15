using CollegeProjectMVC;
using CollegeProjectMVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CollegeProjectMVC.Tests.Controllers
{
    [TestClass]
    public class RegisterCourseTest
    {

        [TestMethod]
        public void RegCourses()
        {
            // Arrange
            RegisterCourseController controller = new RegisterCourseController();

            // Act
            ViewResult result = controller.RegCourses() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
