using Microsoft.AspNetCore.Mvc;
using WebApplicationHW2.Models;

namespace WebApplicationHW2.Controllers
{
    public class ProfessionController : Controller
    {
        public IActionResult Index(string previsioninfo, Profession profession)
        {
            ViewData["profession"] = profession;
            ViewData["previsioninfo"] = previsioninfo;
            return View();
        }
    }
}
