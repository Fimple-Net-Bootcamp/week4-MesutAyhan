﻿using Microsoft.AspNetCore.Mvc;

namespace week4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
