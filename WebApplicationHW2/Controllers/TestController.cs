using Microsoft.AspNetCore.Mvc;
using WebApplicationHW2.Models;

namespace WebApplicationHW2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string previsioninfo, string profdescr)
        {
            ViewData["personData"] = previsioninfo;
            ViewData["profdescr"] = profdescr;

            return View();
        }
    }
}
