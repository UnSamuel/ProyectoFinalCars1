using Microsoft.AspNetCore.Mvc;
using ProjectCars.Context;
using ProjectCars.Models;


namespace ProjectCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnunciosController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public AnunciosController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarAnuncios")]
        public async Task<IActionResult> MostrarAnuncios()
        {
            List<Anuncios> anuncios = aplicacionContext.Anuncios.OrderByDescending(anuncios => anuncios.id_anuncios).ToList();
            return StatusCode(StatusCodes.Status200OK, anuncios);

        }
        [HttpPost]
        [Route("CrearAnuncios")]
        public async Task<IActionResult> CrearAnuncios([FromBody] Anuncios anuncios)
        {
            aplicacionContext.Anuncios.Add(anuncios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarAnuncios")]
        public async Task<IActionResult> EditarAnuncios([FromBody] Anuncios anuncios)
        {
            aplicacionContext.Anuncios.Update(anuncios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarAnuncios/")]
        public async Task<IActionResult> EliminarAnuncios(int id)
        {
            Anuncios anuncios = aplicacionContext.Anuncios.Find(id);
            aplicacionContext.Anuncios.Remove(anuncios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }
    }
}

