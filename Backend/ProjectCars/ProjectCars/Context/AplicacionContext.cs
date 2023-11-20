using Microsoft.EntityFrameworkCore;
using ProjectCars.Models;

namespace ProjectCars.Context
{
    public class AplicacionContext : DbContext

    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
            : base(options)
        { 

        }
        public DbSet<Anuncios> Anuncios { get; set; }
        public DbSet<Articulosblog> Articulosblog { get; set; }
        public DbSet<Resenias> Resenias { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }



    }
}
