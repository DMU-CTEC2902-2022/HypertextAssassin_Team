using CollegeProjectMVC;
using CollegeProjectMVC.Controllers;
using CollegeProjectMVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CollegeProjectMVC.Tests.Controllers
{
    [TestClass]
    public class CyberSecurityTest
    {
        [TestMethod]

        public void CSModuleCode()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            //Act
            ViewResult viewResult = controller.Modules();
            CyberSecurity result = viewResult.Model as CyberSecurity;

            // Assert
            Assert.AreEqual("SE3901", result.ModuleCode);
        }
        [TestMethod]
        public void CSModuleTitle()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            //Act
            ViewResult viewResult = controller.Modules();
            CyberSecurity result = viewResult.Model as CyberSecurity;
            

            // Assert
            Assert.AreEqual("C Programming.", result.ModuleTitle);
        }
        [TestMethod]
        public void CSModuleDescription()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            //Act
            ViewResult viewResult = controller.Modules();
            CyberSecurity result = viewResult.Model as CyberSecurity;


            // Assert
            Assert.AreEqual("C is a general-purpose computer programming language. It was created in the 1970s and remains very widely used and influential. By design, C's features cleanly reflect the capabilities of the targetted CPUs.", result.ModuleDescription);
        }
        [TestMethod]
        public void CSModuleContents()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            //Act
            ViewResult viewResult = controller.Modules();
            CyberSecurity result = viewResult.Model as CyberSecurity;


            // Assert
            Assert.AreEqual("Foundations, and C Coding.", result.ModuleContents);
        }
        [TestMethod]
        public void CSStaffMembers()
        {
            // Arrange
            CyberSecurityController controller = new CyberSecurityController();

            //Act
            ViewResult viewResult = controller.Modules();
            CyberSecurity result = viewResult.Model as CyberSecurity;


            // Assert
            Assert.AreEqual("Dr.Albert, Dr.Ein, Dr.Aron.", result.StaffMembers);
        }

    }
}
