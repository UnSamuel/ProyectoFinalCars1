using Microsoft.AspNetCore.Mvc;
using ProjectCars.Context;
using ProjectCars.Models;


namespace ProjectCars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public UsuariosController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarUsuarios")]
        public async Task<IActionResult> MostrarUsuarios()
        {
            List<Usuarios> usuarios = aplicacionContext.Usuarios.OrderByDescending(usuarios => usuarios.id_usuarios).ToList();
            return StatusCode(StatusCodes.Status200OK, usuarios);

        }
        [HttpPost]
        [Route("CrearUsuarios")]
        public async Task<IActionResult> CrearUsuarios([FromBody] Usuarios usuarios)
        {
            aplicacionContext.Usuarios.Add(usuarios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarUsuarios")]
        public async Task<IActionResult> EditarUsuarios([FromBody] Usuarios usuarios)
        {
            aplicacionContext.Usuarios.Update(usuarios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarUsuarios/")]
        public async Task<IActionResult> EliminarUsuarios(int id)
        {
            Usuarios usuarios = aplicacionContext.Usuarios.Find(id);
            aplicacionContext.Usuarios.Remove(usuarios);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }
    }
}
