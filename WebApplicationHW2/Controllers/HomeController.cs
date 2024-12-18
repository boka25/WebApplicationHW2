using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationHW2.DataClass;
using WebApplicationHW2.Models;

namespace WebApplicationHW2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public UserData personDataUser = new UserData();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonData personData)
        {
            personDataUser.personData = personData;
            ViewData["personData"] = personData;
            return View("Profession");
        }
        public IActionResult Profession(Profession profession)
        {
            personDataUser.Profession = profession;
            ViewData["personData"] = personDataUser.personData;
            return View("Test1");
        }

        public string Privacy()
        {
            return "111";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
