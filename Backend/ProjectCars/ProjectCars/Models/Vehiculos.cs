using System.ComponentModel.DataAnnotations;

namespace ProjectCars.Models
{
    public class Vehiculos
    {
        [Key]
        public int id_vehiculos { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string anio { get; set; }
        public float precio { get; set; }
        public string procedencia { get; set; }
        public string imagenes { get; set; }

        public int id_vendedor { get; set; }





    }
}
