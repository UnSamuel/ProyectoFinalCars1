using System.ComponentModel.DataAnnotations;

namespace ProjectCars.Models
{
    public class Usuarios
    {
        [Key]
        public int id_usuarios { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool genero { get; set; }
        public string lugar_residencia  { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
    }
}
