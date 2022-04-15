﻿using CollegeProjectMVC;
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
    public class ComputerScienceTest
    {
        //Computer Science module code testing
        [TestMethod]
        public void ModuleCode()
        {
            // Arrange
            ComputerScienceController controller = new ComputerScienceController();

            //Act
            ViewResult viewResult = controller.Modules();
            ComputerScience result = viewResult.Model as ComputerScience;

            // Assert
            Assert.AreEqual("COS1903 ", result.ModuleCode);
        }

        //Computer Science Module title testing
        [TestMethod]
        public void ModuleTitle()
        {
            // Arrange
            ComputerScienceController controller = new ComputerScienceController();

            //Act
            ViewResult viewResult = controller.Modules();
            ComputerScience result = viewResult.Model as ComputerScience;

            // Assert
            Assert.AreEqual("Scala Programming.", result.ModuleTitle);
        }

        //Computer Science module description testing
        [TestMethod]
        public void ModuleDescription()
        {
            // Arrange
            ComputerScienceController controller = new ComputerScienceController();

            //Act
            ViewResult viewResult = controller.Modules();
            ComputerScience result = viewResult.Model as ComputerScience;

            // Assert
            Assert.AreEqual("Scala is a strong statically typed general-purpose programming language which supports both object-oriented programming and functional programming. Designed to be concise, many of Scala's design decisions are aimed to address criticisms of Java.", result.ModuleDescription);
        }

        //Computer Science module contents testing
        [TestMethod]
        public void ModuleContents()
        {
            // Arrange
            ComputerScienceController controller = new ComputerScienceController();

            //Act
            ViewResult viewResult = controller.Modules();
            ComputerScience result = viewResult.Model as ComputerScience;

            // Assert
            Assert.AreEqual("Scala Coding, Java Virtual Machine, and OOP.", result.ModuleContents);
        }

        //Computer Science staff members testing
        [TestMethod]
        public void StaffMembers()
        {
            // Arrange
            ComputerScienceController controller = new ComputerScienceController();

            //Act
            ViewResult viewResult = controller.Modules();
            ComputerScience result = viewResult.Model as ComputerScience;

            // Assert
            Assert.AreEqual("Dr.Alber, Dr.Christopher, Dr.Liam.", result.StaffMembers);
        }
    }
    
}
