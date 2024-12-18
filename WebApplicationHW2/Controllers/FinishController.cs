using Microsoft.AspNetCore.Mvc;
using WebApplicationHW2.Models;

namespace WebApplicationHW2.Controllers
{
    public class FinishController : Controller
    {
        public IActionResult Index(string previsioninfo, string answer)
        {
            int points = 0;
            var intAnswer = int.Parse(answer);
            if(intAnswer==3)
                points++;
            ViewData["personData"] = previsioninfo;
            ViewData["answer"] = points.ToString();
            return View();
        }
    }
}
