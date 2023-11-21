using Microsoft.AspNetCore.Mvc;
using ProjectCars.Models;
using ProjectCars.Context;


namespace ProjectCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReseniasController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public ReseniasController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarResenias")]
        public async Task<IActionResult> MostrarResenias()
        {
            List<Resenias> resenias = aplicacionContext.Resenias.OrderByDescending(resenias => resenias.id_resenias).ToList();
            return StatusCode(StatusCodes.Status200OK, resenias);

        }
        [HttpPost]
        [Route("CrearResenias")]
        public async Task<IActionResult> CrearResenias([FromBody] Resenias resenias)
        {
            aplicacionContext.Resenias.Add(resenias);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarResenias")]
        public async Task<IActionResult> EditarResenias([FromBody] Resenias resenias)
        {
            aplicacionContext.Resenias.Update(resenias);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarResenias/")]
        public async Task<IActionResult> EliminarResenias(int id)
        {
            Resenias resenias = aplicacionContext.Resenias.Find(id);
            aplicacionContext.Resenias.Remove(resenias);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }
    }
}
