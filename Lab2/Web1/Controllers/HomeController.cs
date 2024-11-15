using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web1.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Web1.Controllers
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

        //URL: localhost:PORT/Controller_Name/Action_Name
        //URL: localhost:PORT/Home/About
        [Route("/aboutus")]
        public IActionResult About()
        {
            string about = "This is web demo for module 1670 - Application Development";
            //Pass data to View
            //Method 1: ViewBag
            ViewBag.About = about;
            ViewBag.Year = 2024;

            //Method 2: ViewData
            ViewData["copyright"] = "Copyright by Greenwich Vietnam";

            //Method 3: TempData
            TempData["message"] = "Login succeed";

            //render view
            //Path: Views/Controller_Name/Action_Name
            //Path: Views/Home/About.cshtml
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
