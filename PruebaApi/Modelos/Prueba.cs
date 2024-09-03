using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaApi.Modelos
{
    public class Prueba
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //se asigna automaticamente el ID incrementando de 1 en 1
        public int Id { get; set; }


        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        [Required]
        public string Apellido { get;set; }

        public uint celular {  get; set; }

        public string email {  get; set; }




    }
}
