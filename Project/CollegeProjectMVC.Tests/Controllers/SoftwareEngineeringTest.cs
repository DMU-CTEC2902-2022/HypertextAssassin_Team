//HypertextAssassin Team(https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team)
//Members:

//Syed - p2652259 Github(https://github.com/No3Mc) Developer/System Analyst:
//Umar - P2630030 Github(https://github.com/itsumarsoomro) Developer

//Victor - P2622897 Github(https://github.com/VictorTooHauAn) System Analyst
//Pierrick - P2611172 Github(https://github.com/Riick91) System Analyst

//Wiki:

//Syed: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Syed's-Wiki
//Umar: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Umar's-Wiki
//Victor: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Victor-Too-Hau-An---Coordinator-role
//Pierrick: https://github.com/DMU-CTEC2902-2022/HypertextAssassin_Team/wiki/Pierrick-Njiki-An-Coordinator-role



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
