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
    public class CyberSecurityTest
    {
        //CyberSecurity module code testing
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

        //CyberSecurity module title testing
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

        //CyberSecurity module description testing
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

        //CyberSecurity module contents testing
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

        //CyberSecurity staff members testing
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
