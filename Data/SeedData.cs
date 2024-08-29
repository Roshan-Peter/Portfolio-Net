using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Data
{
    public class SeedData
    {
        private readonly AboutService _aboutService;
        private readonly ProjectsService _projectsService;
        private readonly EducationService _educationService;

        public SeedData(AboutService aboutService, ProjectsService projectsService, EducationService educationService)
        {
            _aboutService = aboutService;
            _projectsService = projectsService;
            _educationService = educationService;
        }

        public async Task InitializeAsync()
        {
            var abouts = _aboutService.GetAbouts();

            var seedAbouts = new List<About>
            {
                new About {AboutText = "I am a dedicated software developer with a good knowledge of creating Web and Android apps. My academic background has equipped me with a solid understanding of many programming languages. Throughout my studies and the software I have made, I have developed a keen eye for detail and a passion for writing clean and efficient code. I am eager to apply my skills and enthusiasm and contribute to innovative projects." },
            };

            if (abouts.Count < 1)
            {
                foreach (var about in seedAbouts)
                {
                    _aboutService.CreateAbout(about);
                }
            }


            var education = _educationService.GetEducation();

            var seedEducation = new List<Education>
            {
                new Education { Title = "Mahatama Gandhi University Kerala India (2018 - 2021)", Description = "Graduated from Mahatama Gandhi University in Bachelors in Computer Application (BCA)." },
                new Education { Title = "Conestoga College Ontario Canada (2023 - 2024)", Description = "Graduated from Conestoga College in software development." },
            };

            if(education.Count < 1)
            {
                foreach (var edu in seedEducation)
                {
                    _educationService.CreateEducation(edu);
                }
            }


            var projects = _projectsService.GetProjects();


            var seedProjects = new List<Projects>
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
                }
            };


            if (projects.Count < 1)
            {
                foreach (var project in seedProjects)
                {
                    _projectsService.CreateProject(project);
                }
            }

        }
    }
}
