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
        public FondeadoresController(IConfiguration conf)
        {
            _conf = conf;
            apiEndpoint = _conf.GetSection("apiendpoint").Value;
        }

        public IActionResult Nuevo()
        {
            ViewBag.endpoint = apiEndpoint;
            return View();
        }

        public IActionResult Todos()
        {
            ViewBag.endpoint = apiEndpoint;
            return View();
        }
    }
}