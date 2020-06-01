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
        private readonly string domain;
        public CarterasController(IConfiguration conf)
        {
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
            domain = _conf.GetSection("domain").Value;
        }

        public IActionResult Crear(int carteraID = 0, int productoID = 0, int fondeadorID = 0, int repro = 0)
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;

            ViewBag.carteraID = carteraID;
            ViewBag.productoID = productoID;
            ViewBag.fondeadorID = fondeadorID;
            ViewBag.repro = repro;

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