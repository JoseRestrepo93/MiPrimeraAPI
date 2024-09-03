using PruebaApi.Modelos.Dto;

namespace PruebaApi.Datos
{
    public static class PruebaDatos
    {

        public static List<PruebaDto> PruebaList = new List<PruebaDto>
        {
            new PruebaDto{Id = 1, Nombre = "Jose", Apellido = "Restrepo"},
            new PruebaDto{Id = 2, Nombre = "Laura", Apellido = "Camargo"}


        };
    }
}
