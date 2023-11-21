using Microsoft.AspNetCore.Mvc;
using ProjectCars.Context;
using ProjectCars.Models;


namespace ProjectCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticulosblogController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public ArticulosblogController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarArticulosblog")]
        public async Task<IActionResult> MostrarArticulosblog()
        {
            List<Articulosblog> articulosblog = aplicacionContext.Articulosblog.OrderByDescending(articulosblog => articulosblog.id_articulosblog).ToList();
            return StatusCode(StatusCodes.Status200OK, articulosblog);

        }
        [HttpPost]
        [Route("CrearArticulosblog")]
        public async Task<IActionResult> CrearArticulosblog([FromBody] Articulosblog articulosblog)
        {
            aplicacionContext.Articulosblog.Add(articulosblog);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarArticulosblog")]
        public async Task<IActionResult> EditarArticulosblog([FromBody] Articulosblog articulosblog)
        {
            aplicacionContext.Articulosblog.Update(articulosblog);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarEmpleado/")]
        public async Task<IActionResult> EliminarArticulosblog(int id)
        {
            Articulosblog articulosblog = aplicacionContext.Articulosblog.Find(id);
            aplicacionContext.Articulosblog.Remove(articulosblog);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }
    }
}
