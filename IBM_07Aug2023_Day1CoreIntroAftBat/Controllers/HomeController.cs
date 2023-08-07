using Microsoft.AspNetCore.Mvc;

namespace IBM_07Aug2023_Day1CoreIntroAftBat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
