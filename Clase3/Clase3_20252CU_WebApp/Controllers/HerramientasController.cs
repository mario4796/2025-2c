using Clase3_Entidades;
using Clase3_Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3_20252CU_WebApp.Controllers
{
    public class HerramientasController : Controller
    {
        private IHerramientaServicio _herramientaServicio;

        public HerramientasController(IHerramientaServicio herramientaServicio)
        {
            _herramientaServicio = herramientaServicio;
        }
        public IActionResult Index()
        {
            return View(_herramientaServicio.ObtenerHerramientas());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Herramienta herramienta)
        {
            _herramientaServicio.AgregarHerramienta(herramienta);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _herramientaServicio.EliminarHerramienta(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var herramienta = _herramientaServicio.ObtenerHerramientaPorId(id);
            if (herramienta == null)
                return NotFound();
            return PartialView("EditModal", herramienta); // Partial view for modal
        }

        [HttpPost]
        public IActionResult Edit(Herramienta herramienta)
        {
            // You need to implement update logic in your service
            _herramientaServicio.ActualizarHerramienta(herramienta);
            return RedirectToAction("Index");
        }
    }
}
