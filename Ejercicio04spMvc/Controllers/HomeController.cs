using Ejercicio04spMvc.Models;
using Ejercicio04spMvc.Models.ENT;
using Ejercicio04spMvc.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Ejercicio04spMvc.Models.VM;

namespace Ejercicio04spMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult EditarPersona()
        {
            ClsPersona persona = ClsListado.ObtenerPersonaAleatoria(); // Llamada al m�todo est�tico

            var viewModel = new ClsEditarPersonaVM
            {
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                idDepartamento = persona.idDepartamento
            };

            return View(viewModel);
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