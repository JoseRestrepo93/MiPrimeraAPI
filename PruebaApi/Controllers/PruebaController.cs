using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaApi.Datos;
using PruebaApi.Modelos;
using PruebaApi.Modelos.Dto;

namespace PruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {

        private readonly ApplicationDbContext _db;

        public PruebaController( ApplicationDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PruebaDto>> GetPrueba()
        {
            return Ok(_db.pruebas.ToList());
        }

        [HttpGet("id: int", Name = "GetPrueba")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<PruebaDto> GetPorDato(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            //var prueba = PruebaDatos.PruebaList.FirstOrDefault(p => p.Id == id);
            var prueba = _db.pruebas.FirstOrDefault(x => x.Id == id);

            if (prueba == null)
            {

                return NotFound();

            }

            return Ok(prueba);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<PruebaDto> CrearRegistro([FromBody] PruebaDto parametro)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            if (parametro == null)
            {
                return BadRequest(parametro);
            }

            if (parametro.Id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Prueba modelo = new()
            {

                Nombre = parametro.Nombre,
                Apellido = parametro.Apellido,
                celular = parametro.celular,
                email = parametro.email

            };

            _db.pruebas.Add(modelo);
            _db.SaveChanges();

            return Ok(modelo);
        }

        [HttpDelete("Id: Int")]
        public IActionResult BorrarPrueba(int id)
        {

            if (id == 0)
            {
                return BadRequest();

            }

            var prueba = _db.pruebas.FirstOrDefault(p => p.Id == id);

            if (prueba == null)
            {

                return NotFound();
            }

            _db.pruebas.Remove(prueba);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("Id: Int")]

        public IActionResult ActualizarDatos(int id, [FromBody] PruebaDto parametro)
        {
            if (parametro == null || id != parametro.Id)
            {
                return BadRequest();
            }

            Prueba modelo = new()
            {
                Id = parametro.Id,
                Nombre = parametro.Nombre,
                Apellido = parametro.Apellido,
                celular = parametro.celular,
                email = parametro.email,

            };

            _db.pruebas.Update(modelo);
            _db.SaveChanges();

            return NoContent();


        }
    } 
}
