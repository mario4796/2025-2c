using Microsoft.AspNetCore.Mvc;
using CLASE4_POO_Servicio;
using CLASE4_POO_Entidades;

namespace CLASE4_POO_20252C_WebApp.Controllers
{
    public class AnimalesController : Controller
    {
        private IAnimalesServicio _animalesServicio;

        public AnimalesController(IAnimalesServicio animalesServicio)
        {
            _animalesServicio = animalesServicio;
        }

        public IActionResult Listar()
        {
            return View(_animalesServicio.ObtenerAnimales());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(string Nombre, string TipoAnimal)
        {
            Animal nuevoAnimal = null;
            if (TipoAnimal == "Pato")
                nuevoAnimal = new Pato(Nombre);
            else if (TipoAnimal == "Vaca")
                nuevoAnimal = new Vaca(Nombre);

            if (nuevoAnimal != null)
                _animalesServicio.AgregarAnimal(nuevoAnimal);

            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Eliminar(int indice)
        {
            _animalesServicio.EliminarAnimalPorIndice(indice);
            return RedirectToAction("Listar");
        }
    }
}
