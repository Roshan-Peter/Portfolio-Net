using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;
using Portfolio.Data;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EducationService _educationService;
        private readonly AboutService _aboutService;
        private readonly ProjectsService _projectsService;
        private readonly MessageService _messageService;
        public HomeController(
            ILogger<HomeController> logger, 
            EducationService educationService,
            AboutService aboutService,
            ProjectsService projectsService
,
            MessageService messageService
            )
        {
            _logger = logger;
            _educationService = educationService;
            _aboutService = aboutService;
            _projectsService = projectsService;
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/about")]
        public IActionResult About()
        {
            var educationList = _educationService.GetEducation();
            var about = _aboutService.GetAbouts();
            var projects = _projectsService.GetProjects();

            TempData["EducationList"] = educationList;
            TempData["About"] = about.First().AboutText;
            TempData["projects"] = _projectsService.GetProjects()
                                                   .Where(p => p.Priority == 1)
                                                   .ToList(); 

            return View();
        }

        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            TempData["projects"] = _projectsService.GetProjects();
            return View();
        }

        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("/contact")]
        public IActionResult Contact(Message model)
        {
            if(string.IsNullOrEmpty(model.Email))
            {
                model.Email = "";
            }

            if (ModelState.IsValid)
            {
                try
                {
                    TempData["code"] = "1";

                    _messageService.CreateMessage(model);
                    return RedirectToAction("Contact");
                }
                catch (Exception)
                {
                    return View(model);
                }
            }

            TempData["code"] = "0";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
