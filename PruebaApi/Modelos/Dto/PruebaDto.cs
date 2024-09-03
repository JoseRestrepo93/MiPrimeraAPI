using System.ComponentModel.DataAnnotations;

namespace PruebaApi.Modelos.Dto
{
    public class PruebaDto
    {

        public int Id { get; set; }

        
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        public string Apellido {  get; set; }

        public uint celular { get; set; }

        public string email { get; set; }


    }
}
