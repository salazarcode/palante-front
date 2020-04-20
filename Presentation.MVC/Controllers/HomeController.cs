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

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env, IConfiguration conf)
        {
            _logger = logger;
            _env = env;
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
        }

        public IActionResult Index()
        {
            ViewBag.endpoint = apiEndpoint;
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
    }
}
