using Clase2._2C2025.Logica;
using Clase2._202025.Entidad;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2._2C2025.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoLocalController : ControllerBase
    {
        ITipoLocalServicio _tipoLocalServicio;
        public TipoLocalController(ITipoLocalServicio tipoLocalServicio)
        {
            _tipoLocalServicio = tipoLocalServicio;
        }

        [HttpGet]
        public IActionResult GetTiposLocal()
        {
            return Ok(_tipoLocalServicio.ObtenerTiposLocal());
        }

        [HttpPost]
        public IActionResult PostTipoLocal([FromBody] TipoLocal tipoLocal)
        {
            _tipoLocalServicio.AgregarTipoLocal(tipoLocal);
            return Ok();
        }
    }
}
