using LiveSports.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LiveSports.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> ILogger;

        public HomeController(ILogger<HomeController> logger)
        {
            ILogger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
        public IActionResult Membership()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult InternationalCricket()
        {
            return View();
        }
        public IActionResult Football()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View(); 
        }

        public IActionResult DomesticCricket()
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
