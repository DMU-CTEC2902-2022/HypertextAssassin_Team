using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollegeProjectMVC.Models;

namespace CollegeProjectMVC.Controllers
{
    public class SoftwareEngineeringController : Controller
    {
        // GET: SoftwareEngineering
        public ViewResult Modules()
        {
            //SoftwareEngineering Modules0
            SoftwareEngineering SEModel = new SoftwareEngineering();
            SEModel.ModuleCode = "SE3906";
            SEModel.ModuleTitle = "Interaction Design";
            SEModel.ModuleDescription = "Interaction design, often abbreviated as IxD, is the practice of designing interactive digital products, environments, systems, and services. Beyond the digital aspect, interaction design is also useful when creating physical products, exploring how a user might interact with it.";
            SEModel.ModuleContents = "asdasdfasfas";
            SEModel.StaffMembers = "Dr.Abraham, Dr.Nelson, Dr.Hzik";

            //SoftwareEngineering Modules1
            SoftwareEngineering SEModel1 = new SoftwareEngineering();
            SEModel.ModuleCode1 = "SE3410";
            SEModel.ModuleTitle1 = "Web Application Penetration Testing";
            SEModel.ModuleDescription1 = "A web application penetration test is a type of ethical hacking engagement designed to assess the architecture, design and configuration of web applications. Assessments are conducted to identify cyber security risks that could lead to unauthorised access and/or data exposure.";
            SEModel.ModuleContents1 = "asdasdfasfas";
            SEModel.StaffMembers1 = "Dr.Alber, Christopher, Dr.Anita";
            
            //SoftwareEngineering Modules2
            SoftwareEngineering SEModel2 = new SoftwareEngineering();
            SEModel.ModuleCode2 = "SE3406";
            SEModel.ModuleTitle2 = "Fuzzy Logic & Knowledge Based Systems";
            SEModel.ModuleDescription2 = "In fuzzy logic systems, the fuzzy knowledge base represents the facts of the rules and linguistic variables based on the fuzzy set theory so that the knowledge base sytems will allow approximate reasoning.";
            SEModel.ModuleContents2 = "asdasdfasfas";
            SEModel.StaffMembers2 = "Dr.Kabiru, Dr.Moath, Dr.Abdullah";

            //SoftwareEngineering Modules3
            SoftwareEngineering SEModel3 = new SoftwareEngineering();
            SEModel.ModuleCode3 = "SE3613";
            SEModel.ModuleTitle3 = "Data Mining";
            SEModel.ModuleDescription3 = "Data mining is the process of finding anomalies, patterns and correlations within large data sets to predict outcomes. Using a broad range of techniques, you can use this information to increase revenues, cut costs, improve customer relationships, reduce risks and more.";
            SEModel.ModuleContents3 = "asdasdfasfas";
            SEModel.StaffMembers3 = "Mathew Dean, Dr.Martin Stacey, Dr.Dean M";

            //SoftwareEngineering Modules4
            SoftwareEngineering SEModel4 = new SoftwareEngineering();
            SEModel.ModuleCode4 = "SE3614";
            SEModel.ModuleTitle4 = "Big Data & Business Models";
            SEModel.ModuleDescription4 = "The big data business models can be classified into four types: Data Users: Businesses which use data to form strategies and build better products.";
            SEModel.ModuleContents4 = "asdasdfasfas";
            SEModel.StaffMembers4 = "Dr.Jhonston, Dr.Thomas, Dr.Archie Singh";

            //SoftwareEngineering Modules5
            SoftwareEngineering SEModel5 = new SoftwareEngineering();
            SEModel.ModuleCode5 = "IMAT3611";
            SEModel.ModuleTitle5 = "Computer Ethics and Privacy";
            SEModel.ModuleDescription5 = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers.";
            SEModel.ModuleContents5 = "asdasdfasfas";
            SEModel.StaffMembers5 = "Dr.Paras, Dr.Sharan, Dr.Liam";

            //SoftwareEngineering Modules6
            SoftwareEngineering SEModel6 = new SoftwareEngineering();
            SEModel.ModuleCode6 = "SE3451";
            SEModel.ModuleTitle6 = "Development Project";
            SEModel.ModuleDescription6 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
            SEModel.ModuleContents6 = "asdasdfasfas";
            SEModel.StaffMembers6 = "Dr.Usama, Dr.Liv, Dr.Ben";
            return View(SEModel);
        }
    }
}