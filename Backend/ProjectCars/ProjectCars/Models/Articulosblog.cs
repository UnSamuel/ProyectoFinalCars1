using System.ComponentModel.DataAnnotations;

namespace ProjectCars.Models
{
    public class Articulosblog
    {
        [Key]
        public int id_articulosblog { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public string fecha_publicacion { get; set; }

        public int id_usuario { get; set; }

    }
}
