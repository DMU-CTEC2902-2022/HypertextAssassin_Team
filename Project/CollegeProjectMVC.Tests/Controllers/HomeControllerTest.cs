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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CollegeProjectMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        //Home Index testing
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //About tab/page on homepage testing
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Contact page/tab on homepage testing
        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Courses page/tab on homepage testing
        [TestMethod]
        public void Course()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Course() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //CSModule testing on the course tab/page in homepage 
        [TestMethod]
        public void CSModule()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.CSModule() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
