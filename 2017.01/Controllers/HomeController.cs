﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2017._01.Models;
using Lib.Application.Core.Interfaces;

namespace _2017._01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductAppService _productAppService;
        public HomeController(IProductAppService pProductAppService)
        {
            _productAppService = pProductAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
