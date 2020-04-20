using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Presentation.MVC.Controllers
{
    public class CarterasController : Controller
    {
        private readonly IConfiguration _conf;
        private readonly string apiEndpoint;
        public CarterasController(IConfiguration conf)
        {
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
        }

        public IActionResult Nueva()
        {
            ViewBag.endpoint = apiEndpoint;
            return View();
        }

        public IActionResult Todas()
        {
            ViewBag.endpoint = apiEndpoint;
            return View();
        }
    }
}