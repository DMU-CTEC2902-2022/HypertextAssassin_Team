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
    public class SoftwareEngineeringTest
    {
        //SoftwareEngineering Module code testing
        [TestMethod]
        public void SEMModuleCode()
        {
            // Arrange
            SoftwareEngineeringController controller = new SoftwareEngineeringController();

            //Act
            ViewResult viewResult = controller.Modules();
            SoftwareEngineering result = viewResult.Model as SoftwareEngineering;

            // Assert
            Assert.AreEqual("SE3906", result.ModuleCode);
        }

        //SoftwareEngineering module title testing
        [TestMethod]
        public void SEMModuleTitle()
        {
            // Arrange
            SoftwareEngineeringController controller = new SoftwareEngineeringController();

            //Act
            ViewResult viewResult = controller.Modules();
            SoftwareEngineering result = viewResult.Model as SoftwareEngineering;


            // Assert
            Assert.AreEqual("Interaction Design.", result.ModuleTitle);
        }

        //SoftwareEngineering module description testing
        [TestMethod]
        public void SEMModuleDescription()
        {
            // Arrange
            SoftwareEngineeringController controller = new SoftwareEngineeringController();

            //Act
            ViewResult viewResult = controller.Modules();
            SoftwareEngineering result = viewResult.Model as SoftwareEngineering;


            // Assert
            Assert.AreEqual("Interaction design, often abbreviated as IxD, is the practice of designing interactive digital products, environments, systems, and services. Beyond the digital aspect, interaction design is also useful when creating physical products, exploring how a user might interact with it.", result.ModuleDescription);
        }

        //SoftwareEngineering module contents testing
        [TestMethod]
        public void SEMModuleContents()
        {
            // Arrange
            SoftwareEngineeringController controller = new SoftwareEngineeringController();

            //Act
            ViewResult viewResult = controller.Modules();
            SoftwareEngineering result = viewResult.Model as SoftwareEngineering;


            // Assert
            Assert.AreEqual("Foudations and Importance of Design.", result.ModuleContents);
        }

        //SoftwareEngineering staff members testing
        [TestMethod]
        public void SEMStaffMembers()
        {
            // Arrange
            SoftwareEngineeringController controller = new SoftwareEngineeringController();

            //Act
            ViewResult viewResult = controller.Modules();
            SoftwareEngineering result = viewResult.Model as SoftwareEngineering;


            // Assert
            Assert.AreEqual("Dr.Abraham, Dr.Nelson, Dr.Hzik.", result.StaffMembers);
        }
    }
}
