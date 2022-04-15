using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollegeProjectMVC.Models;

namespace CollegeProjectMVC.Controllers
{
    public class ComputerScienceController : Controller
    {
        public ViewResult Modules()
        {
            //ComputerScience Modules0
            ComputerScience CSModel = new ComputerScience();
            CSModel.ModuleCode = "COS1903 ";
            CSModel.ModuleTitle = "Scala Programming.";
            CSModel.ModuleDescription = "Scala is a strong statically typed general-purpose programming language which supports both object-oriented programming and functional programming. Designed to be concise, many of Scala's design decisions are aimed to address criticisms of Java.";
            CSModel.ModuleContents = "Scala Coding, Java Virtual Machine, and OOP.";
            CSModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules1
            ComputerScience CSModel1 = new ComputerScience();
            CSModel.ModuleCode1 = "COS1920";
            CSModel.ModuleTitle1 = "Database Management";
            CSModel.ModuleDescription1 = "Database management refers to the actions a business takes to manipulate and control data to meet necessary conditions throughout the entire data lifecycle.";
            CSModel.ModuleContents1 = "Database design, and Database development.";
            CSModel.StaffMembers1 = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules2
            ComputerScience CSModel2 = new ComputerScience();
            CSModel.ModuleCode2 = "COS2905";
            CSModel.ModuleTitle2 = "Object Oriented Programming (Java).";
            CSModel.ModuleDescription2 = "Object-oriented programming (OOP) is a computer programming model that organizes software design around data, or objects, rather than functions and logic. An object can be defined as a data field that has unique attributes and behavior.";
            CSModel.ModuleContents2 = "Foundations, and Coding languages.";
            CSModel.StaffMembers2 = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules3
            ComputerScience CSModel3 = new ComputerScience();
            CSModel.ModuleCode3 = "COS3911";
            CSModel.ModuleTitle3 = "Mobile Application.";
            CSModel.ModuleDescription3 = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones. These software applications are designed to run on mobile devices, such as a smartphone or tablet computer";
            CSModel.ModuleContents3 = "App coding, and Foundations.";
            CSModel.StaffMembers3 = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules4
            ComputerScience CSModel4 = new ComputerScience();
            CSModel.ModuleCode4 = "IMAT3611";
            CSModel.ModuleTitle4 = "Computer Ethics and Privacy.";
            CSModel.ModuleDescription4 = "Ethics is a set of moral principles that govern the behavior of an individual or group of people. Computer ethics is the application of moral principles to the use of computers and the Internet.";
            CSModel.ModuleContents4 = "Ethics, and Law.";
            CSModel.StaffMembers4 = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules5
            ComputerScience CSModel5 = new ComputerScience();
            CSModel.ModuleCode5 = "COS3451";
            CSModel.ModuleTitle5 = "Development Project.";
            CSModel.ModuleDescription5 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            CSModel.ModuleContents5 = "Project Dev.";
            CSModel.StaffMembers5 = "Dr.Alber, Dr.Christopher, Dr.Liam.";

            //ComputerScience Modules6
            ComputerScience CSModel6 = new ComputerScience();
            CSModel.ModuleCode6 = "COS2910";
            CSModel.ModuleTitle6 = "Database Management.";
            CSModel.ModuleDescription6 = "Database management refers to the actions a business takes to manipulate and control data to meet necessary conditions throughout the entire data lifecycle.";
            CSModel.ModuleContents6 = "Database design, and Database development.";
            CSModel.StaffMembers6 = "Dr.Alber, Dr.Christopher, Dr.Liam";
            return View(CSModel);
        }


    }
}