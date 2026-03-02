using dit.database.net;
using DIT.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIT.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClubService club;
        private CalendarModel _calendar = new CalendarModel();
        public HomeController(ILogger<HomeController> logger, IClubService club)
        {
            _logger = logger;
            this.club = club;
        }

        public IActionResult Index()
        {                        
            return View(_calendar);
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
    }
}