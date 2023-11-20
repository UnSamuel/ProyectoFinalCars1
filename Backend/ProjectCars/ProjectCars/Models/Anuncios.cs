using System.ComponentModel.DataAnnotations;

namespace ProjectCars.Models
{
    public class Anuncios
    {
        [Key]
        public int id_anuncios { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }

        public int id_vehiculo { get; set; }
        public int id_usuario { get; set; }
    }
}
