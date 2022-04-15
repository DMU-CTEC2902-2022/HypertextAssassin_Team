using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollegeProjectMVC.Models;

namespace CollegeProjectMVC.Controllers
{
    public class CyberSecurityController : Controller
    {
        // GET: CyberSecurity
            public ViewResult Modules()
            {

                //CyberSecurity Modules0
                CyberSecurity CSModel = new CyberSecurity();
                CSModel.ModuleCode = "SE3901";
                CSModel.ModuleTitle = "C Programming";
                CSModel.ModuleDescription = "C is a general-purpose computer programming language. It was created in the 1970s and remains very widely used and influential. By design, C's features cleanly reflect the capabilities of the targetted CPUs.";
                CSModel.ModuleContents = "asdasdfasfas";
                CSModel.StaffMembers = "Dr.Albert, Dr.Ein, Dr.Aron";

                //CyberSecurity Modules1
                CyberSecurity CSModel1 = new CyberSecurity();
                CSModel.ModuleCode1 = "SE3902";
                CSModel.ModuleTitle1 = "Computer Law and Cyber Security Management";
                CSModel.ModuleDescription1 = "Cyber security is the application of technologies, processes and controls to protect systems, networks, programs, devices and data from cyber attacks. It aims to reduce the risk of cyber attacks and protect against the unauthorised exploitation of systems, networks and technologies.";
                CSModel.ModuleContents1 = "asdasdfasfas";
                CSModel.StaffMembers1 = "Dr.Jethro, Dr.Will, Smith D";

                //CyberSecurity Modules2
                CyberSecurity CSModel2 = new CyberSecurity();
                CSModel.ModuleCode2 = "SE3903";
                CSModel.ModuleTitle2 = "Linux Security";
                CSModel.ModuleDescription2 = "Security. From its very inception, security has been a cornerstone of the Linux operating system. Each user has to be walled off from others, and a password and user ID are required for an individual to use Linux.";
                CSModel.ModuleContents2 = "asdasdfasfas";
                CSModel.StaffMembers2 = "Dr.Niel, Dr.Eaton, Dr.Luke";

                //CyberSecurity Modules3
                CyberSecurity CSModel3 = new CyberSecurity();
                CSModel.ModuleCode3 = "SE3904 ";
                CSModel.ModuleTitle3 = "Cyber Threat Intelligence and Incident Response ";
                CSModel.ModuleDescription3 = "Threat intelligence, or cyber threat intelligence, is information an organization uses to understand the threats that have, will, or are currently targeting the organization. This info is used to prepare, prevent, and identify cyber threats looking to take advantage of valuable resources.";
                CSModel.ModuleContents3 = "asdasdfasfas";
                CSModel.StaffMembers3 = "Dr.Alber, Dr.Christopher, Dr.Liam";

                //CyberSecurity Modules4
                CyberSecurity CSModel4 = new CyberSecurity();
                CSModel.ModuleCode4 = "SE3905";
                CSModel.ModuleTitle4 = "Malware Analysis ";
                CSModel.ModuleDescription4 = "Malware analysis is the process of understanding the behavior and purpose of a suspicious file or URL. The output of the analysis aids in the detection and mitigation of the potential threat.";
                CSModel.ModuleContents4 = "asdasdfasfas";
                CSModel.StaffMembers4 = "Dr.Alex, Dr.Sam, Rock Dietn";

                //CyberSecurity Modules5
                CyberSecurity CSModel5 = new CyberSecurity();
                CSModel.ModuleCode5 = "IMAT3611";
                CSModel.ModuleTitle5 = "Computer Ethics and Privacy ";
                CSModel.ModuleDescription5 = "Privacy in computer ethics refers to the ethical dilemmas that computer users face in some situations that may lead to the violation of another person's privacy through the use of computers. Ethics is a reference to a sense of what is right and wrong.";
                CSModel.ModuleContents5 = "asdasdfasfas";
                CSModel.StaffMembers5 = "Dr.Jay, Dr.Noah, Dr.Racheal";

                //CyberSecurity Modules6
                CyberSecurity CSModel6 = new CyberSecurity();
                CSModel.ModuleCode6 = "SE3451";
                CSModel.ModuleTitle6 = " Development Project";
                CSModel.ModuleDescription6 = "Development Project means any construction, development or infrastructure project, including without limitation greenfield projects and brownfield projects, in which the Company or any of its Subsidiaries participates or holds, directly or indirectly, an interest, or the bidding on any such project.";
                CSModel.ModuleContents6 = "asdasdfasfas";
                CSModel.StaffMembers6 = "Dr.Alber, Dr.Christopher, Dr.Liam";

            return View(CSModel);
            }
        }
    }
