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



using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CollegeProjectMVC;
using CollegeProjectMVC.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CollegeProjectMVC.Tests.Controllers
{
    [TestClass]
    public class RegisterandLoginTest
    {

        //Registeration Testing
        [TestMethod]
        public void Register()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Forgot password testing
        [TestMethod]
        public void ForgotPassword()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ForgotPassword() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Second confirmation of pass testing
        [TestMethod]
        public void FPasswordConfirmation()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ForgotPasswordConfirmation() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Login failure testing
        [TestMethod]
        public void ExternalLoginFailure()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ExternalLoginFailure() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
