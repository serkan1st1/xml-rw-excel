﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskMvc.Models;

namespace TaskMvc.Controllers
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

        public IActionResult Excel()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }


    }
}
