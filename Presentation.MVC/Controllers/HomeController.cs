using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Presentation.MVC.Models;


namespace Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _conf;
        private readonly string apiEndpoint;
        private readonly string domain;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env, IConfiguration conf)
        {
            _logger = logger;
            _env = env;
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
            domain = _conf.GetSection("domain").Value;
        }

        public IActionResult Index()
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            return View();
        }

    }
}
