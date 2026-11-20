using Microsoft.AspNetCore.Mvc;
using MVC01.Models;
using System.Diagnostics;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Search (ProudctFilter filsResercher)
        {
            return View();

        }
        public IActionResult GetById([FromQuery] int Id , [FromQuery(Name = "Id2")] int   OtherId)
        {
            return Json("");

        }
    }
}
