using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Presentation.MVC.Controllers
{
    public class PagosController : Controller
    {
        private readonly IConfiguration _conf;
        private readonly string apiEndpoint;
        private readonly string domain;
        public PagosController(IConfiguration conf)
        {
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
            domain = _conf.GetSection("domain").Value;
        }

        public IActionResult Crear(int PagoID = 0, int fondeador = 0, int producto = 0, int mochila = 0, decimal monto = 0)
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;

            ViewBag.PagoID = PagoID;
            ViewBag.producto = producto;
            ViewBag.fondeador = fondeador;
            ViewBag.mochila = mochila;
            ViewBag.monto = monto;


            if (fondeador == 2 || mochila == 1)
                return View("CrearCapitalMochila");
            else
                return View("CrearEstandar");

        }

        public IActionResult Index()
        {
            ViewBag.endpoint = apiEndpoint;
            ViewBag.domain = domain;
            return View();
        }
    }
}