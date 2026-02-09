using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrafficyLandingPage.Models;

namespace TrafficyLandingPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env, ILogger<HomeController> logger)
        {
            _env = env;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tabsy()
        {
            return View("Tabsy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Serve(string id)
        {
            //Console.WriteLine(id);
            switch (id)
            {
                case "personal_logo":
                    return PhysicalFile(Path.Combine(_env.ContentRootPath, "/app/wwwroot/images/personal_logo.png"), "image/png");
                case "tabsy_icon":
                    return PhysicalFile(Path.Combine(_env.ContentRootPath, "/app/wwwroot/images/tabsyicon.png"), "image/png");
                default:
                    return null;
            }
        }
    }
}
