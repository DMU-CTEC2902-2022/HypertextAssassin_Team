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
