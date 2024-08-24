using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apppractica_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apppractica_1.Controllers
{
    public class OperarBolsaController : Controller
    {
        private readonly ILogger<OperarBolsaController> _logger;

        public OperarBolsaController(ILogger<OperarBolsaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["listaOperaciones"] = new List<Operaciones>();
            return View();
        }

        public IActionResult Operacion(Operaciones operaciones)
        {
            List<Operaciones> listaOperaciones = new List<Operaciones>();
            operaciones.CalcularOperacion();
            listaOperaciones.Add(operaciones);
            ViewData["listaOperaciones"]=listaOperaciones;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}