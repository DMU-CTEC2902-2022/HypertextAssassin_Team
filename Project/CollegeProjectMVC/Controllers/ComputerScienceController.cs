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

            ComputerScience CSModel = new ComputerScience();
            CSModel.ModuleCode = "COS1903 ";
            CSModel.ModuleTitle = "Scala Programming";
            CSModel.ModuleDescription = "Scala is a strong statically typed general-purpose programming language which supports both object-oriented programming and functional programming. Designed to be concise, many of Scala's design decisions are aimed to address criticisms of Java.";
            CSModel.ModuleContents = "asdasdfasfas";
            CSModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";



            return View(CSModel);


            //ComputerScienceModulesModel ModulesModel1 = new ComputerScienceModulesModel();
            //ModulesModel.ModuleCode = "COS1920";
            //ModulesModel.ModuleTitle = "Database Management";
            //ModulesModel.ModuleDescription = "Database management refers to the actions a business takes to manipulate and control data to meet necessary conditions throughout the entire data lifecycle.";
            //ModulesModel.ModuleContents = "asdasdfasfas";
            //ModulesModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";


            //ComputerScienceModulesModel ModulesModel2 = new ComputerScienceModulesModel();
            //ModulesModel.ModuleCode = "COS2905";
            //ModulesModel.ModuleTitle = "Object Oriented Programming (Java)";
            //ModulesModel.ModuleDescription = "Object-oriented programming (OOP) is a computer programming model that organizes software design around data, or objects, rather than functions and logic. An object can be defined as a data field that has unique attributes and behavior.";
            //ModulesModel.ModuleContents = "asdasdfasfas";
            //ModulesModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";

            //ComputerScienceModulesModel ModulesModel3 = new ComputerScienceModulesModel();
            //ModulesModel.ModuleCode = "COS3911";
            //ModulesModel.ModuleTitle = "Mobile Application";
            //ModulesModel.ModuleDescription = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones. These software applications are designed to run on mobile devices, such as a smartphone or tablet computer";
            //ModulesModel.ModuleContents = "asdasdfasfas";
            //ModulesModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";

            //ComputerScienceModulesModel ModulesModel4 = new ComputerScienceModulesModel();
            //ModulesModel.ModuleCode = "IMAT3611";
            //ModulesModel.ModuleTitle = "Computer Ethics and Privacy";
            //ModulesModel.ModuleDescription = "Ethics is a set of moral principles that govern the behavior of an individual or group of people. Computer ethics is the application of moral principles to the use of computers and the Internet.";
            //ModulesModel.ModuleContents = "asdasdfasfas";
            //ModulesModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";

            //ComputerScienceModulesModel ModulesModel5 = new ComputerScienceModulesModel();
            //ModulesModel.ModuleCode = "COS3451";
            //ModulesModel.ModuleTitle = "Development Project ";
            //ModulesModel.ModuleDescription = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            //ModulesModel.ModuleContents = "asdasdfasfas";
            //ModulesModel.StaffMembers = "Dr.Alber, Dr.Christopher, Dr.Liam";

        }


    }
}