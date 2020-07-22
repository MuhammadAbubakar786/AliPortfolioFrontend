using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Aboutme()
        {
            return View();
        }

        public IActionResult Myportfolio()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

       public IActionResult projectpage()
        {
            return View();
        }
        public IActionResult projectcards()
        {
            return View();
        }
        public IActionResult psd()
        {
            return View();
        }
        public IActionResult webapp()
        {
            return View();
        }

    }
}
