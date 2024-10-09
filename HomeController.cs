using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var educationList = new List<Education>
            {
                new Education { Title = "Mahatama Gandhi University Kerala India (2018 - 2021)", Description = "Graduated from Mahatama Gandhi University in Bachelors in Computer Application (BCA)." },
                new Education { Title = "Conestoga College Ontario Canada (2023 - 2024)", Description = "Graduated from Conestoga College in software development." },
            };
            var about = "I am a dedicated software developer with a good knowledge of creating Web and Android apps. My academic background has equipped me with a solid understanding of many programming languages. Throughout my studies and the software I have made, I have developed a keen eye for detail and a passion for writing clean and efficient code. I am eager to apply my skills and enthusiasm and contribute to innovative projects.";
            var projects = GetTopProjects();

            TempData["About"] = about;

            TempData["EducationList"] = educationList;
            TempData["projects"] = projects;

            return View();
        }

        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            TempData["projects"] = GetProjects();
            return View();
        }



        private List<Projects> GetTopProjects()
        {
        return new List<Projects>
                {
                    new Projects
                    {
                        Title = "E-commerce App",
                        Description = "Developed an e-commerce website using Django, Python's web framework. Implemented features such as user authentication and shopping cart functionality. Utilized Django's ORM for seamless database interaction and used PostgreSQL as the database.",
                        Framework = "Django Web App",
                        Technology = new List<Technology>
                        {
                            new Technology{ Name = "Python (Django Framework)" },
                            new Technology { Name = "PostgreSQL" }
                        },
                        Priority = 1
                    },
                    new Projects
                    {
                        Title = "Complaint Registration App",
                        Description = "I have developed comprehensive complaint registration software for web and Android platforms using Java. This software allows users to seamlessly register complaints, track their status, and receive real-time updates. Utilizing Java's robust capabilities and integrating with web and Android environments, the software ensures efficient handling of customer grievances while maintaining a user-friendly interface.",
                        Framework = "Java Web App",
                        Technology = new List<Technology>
                        {
                            new Technology{ Name = "Java, Jsp" },
                            new Technology { Name = "MySQL" }
                        },
                        Priority = 1
                    },
            };
        }


        private List<Projects> GetProjects()
        {
            return new List<Projects>
            {
                new Projects
                {
                    Title = "Bakery Management App",
                    Description = "A web application designed to streamline the operations of a bakery. It allows staff to manage inventory, track orders, and generate reports. The app provides a user-friendly interface for both customers and staff, offering features such as order placement, real-time inventory updates, and customizable product options.",
                    Framework = "Node.js, Express, React",
                    Technology = new List<Technology>
                    {
                        new Technology { Name = "JavaScript" },
                        new Technology { Name = "MongoDB" }
                    },
                },

                new Projects
                {
                    Title = "E-commerce App",
                    Description = "Developed an e-commerce website using Django, Python's web framework. Implemented features such as user authentication and shopping cart functionality. Utilized Django's ORM for seamless database interaction and used PostgreSQL as the database.",
                    Framework = "Django Web App",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "Python (Django Framework)" },
                        new Technology { Name = "PostgreSQL" }
                    },
                    Priority = 1
                },
                new Projects
                {
                    Title = "Complaint Registration App",
                    Description = "I have developed comprehensive complaint registration software for web and Android platforms using Java. This software allows users to seamlessly register complaints, track their status, and receive real-time updates. Utilizing Java's robust capabilities and integrating with web and Android environments, the software ensures efficient handling of customer grievances while maintaining a user-friendly interface.",
                    Framework = "Java Web App",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "Java, Jsp" },
                        new Technology { Name = "MySQL" }
                    },
                    Priority = 1
                },

                new Projects
                {
                    Title = "E-commerce App",
                    Description = "I have designed and implemented a dynamic e-commerce platform for selling electronic devices. Built using .Net Mvc Core and SQLServer databases, the app offers a secure and responsive shopping experience. It includes features such as product listings, user authentication and so on.",
                    Framework = ".NET Web App",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "C#" },
                        new Technology { Name = "SQLServer" }
                    },
                    Priority = 0
                },

                new Projects
                {
                    Title = "E-commerce App",
                    Description = "I have designed and implemented a dynamic e-commerce platform for selling laptops on Android devices. Built using Java and Firebase databases, the app offers a secure and responsive shopping experience. It includes features such as product listings, user authentication and so on.",
                    Framework = "Android App",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "App development using Java" },
                        new Technology { Name = "Firebase" }
                    },
                    Priority = 0
                },

                new Projects
                {
                    Title = "Book Management Application",
                    Description = "I have designed and developed a book management application using .NET (c#), used SQLServer as the database.",
                    Framework = ".Net Application",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "C#" },
                        new Technology { Name = "SQLServer" }
                    },
                    Priority = 0
                },

                new Projects
                {
                    Title = "Driving test booking platform",
                    Description = "I have developed a driving test booking application using Express framework and ejs as the templating engine, I have also used MongoDB for storing data.",
                    Framework = "Node Js, Express Application",
                    Technology = new List<Technology>
                    {
                        new Technology{ Name = "JavaScript" },
                        new Technology { Name = "MongoDB" }
                    },
                    Priority = 0
                },
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
