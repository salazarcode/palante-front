using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Presentation.MVC.Controllers
{
    public class FondeadoresController : Controller
    {
        private readonly IConfiguration _conf;
        private readonly string apiEndpoint;
        private readonly string domain;
        public FondeadoresController(IConfiguration conf)
        {
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
            apiEndpoint = _conf.GetSection("domain").Value;
        }

        public IActionResult Crear(int id = -1)
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            ViewBag.editar = id;
            return View();
        }

        public IActionResult Index()
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            return View();
        }
    }
}