using Microsoft.AspNetCore.Mvc;
using ProjectCars.Context;
using ProjectCars.Models;

namespace ProjectCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public VehiculosController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarVehiculos")]
        public async Task<IActionResult> MostrarVehiculos()
        {
            List<Vehiculos> vehiculos = aplicacionContext.Vehiculos.OrderByDescending(vehiculos => vehiculos.id_vehiculos).ToList();
            return StatusCode(StatusCodes.Status200OK, vehiculos);

        }
        [HttpPost]
        [Route("CrearVehiculos")]
        public async Task<IActionResult> CrearVehiculos([FromBody] Vehiculos vehiculos)
        {
            aplicacionContext.Vehiculos.Add(vehiculos);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarVehiculos")]
        public async Task<IActionResult> EditarVehiculos([FromBody] Vehiculos vehiculos)
        {
            aplicacionContext.Vehiculos.Update(vehiculos);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarVehiculos/")]
        public async Task<IActionResult> EliminarVehiculos(int id)
        {
            Vehiculos vehiculos = aplicacionContext.Vehiculos.Find(id);
            aplicacionContext.Vehiculos.Remove(vehiculos);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }
    }
}
