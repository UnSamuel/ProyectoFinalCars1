using System.ComponentModel.DataAnnotations;

namespace ProjectCars.Models
{
    public class Resenias
    {
        [Key]
        public int id_resenias { get; set; }
        public string comentario { get; set; }
        public string calificacion { get; set; }

        public int id_vendedor { get; set; }
        public int id_comprador { get; set; }

    }
}
