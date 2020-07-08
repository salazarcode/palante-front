using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Presentation.MVC.Controllers
{
    public class AnalisisController : Controller
    {
        private readonly IConfiguration _conf;
        private readonly string apiEndpoint;
        private readonly string domain;
        public AnalisisController(IConfiguration conf)
        {
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

        public IActionResult Credito(string credito)
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            ViewBag.credito = credito;
            return View("Credito");
        }
    }
}