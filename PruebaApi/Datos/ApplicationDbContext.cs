using Azure.Core.Serialization;
using Microsoft.EntityFrameworkCore;
using PruebaApi.Modelos;

namespace PruebaApi.Datos
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
                
        
        public DbSet<Prueba> pruebas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prueba>().HasData(
                new Prueba()
                {
                    Id = 1,
                    Nombre = "Jose",
                    Apellido = "Restrepo",
                    celular = 3196124005,
                    email = "jose.restrepo93@gmail.com",
                    FechaCreacion = DateTime.Now


                },
                new Prueba()
                {
                    Id = 2,
                    Nombre = "laura",
                    Apellido = "Camargo",
                    celular = 3046283763,
                    email = "lauraisabelcamargosalazar@gmail.com",
                    FechaCreacion = DateTime.Now


                }


                );
        }





    }
}
