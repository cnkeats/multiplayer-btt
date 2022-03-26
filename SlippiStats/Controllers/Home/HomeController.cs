using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;

namespace SlippiStats.Controllers
{
    public class HomeController : ApplicationController
    {
        public HomeController(ApplicationSettings settings, ApplicationDatabase database)
            : base(settings, database)
        {

        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Entry");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}