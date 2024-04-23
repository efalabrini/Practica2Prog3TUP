using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web.Ej5;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult GetPruebaAuto([FromQuery] int cantidadCombustible)
        {
            Coche coche = new Coche(0);

            if(coche.CargarCombustible(cantidadCombustible))
            {
                return Ok(coche.Conducir());
            }
            else
            {
                return BadRequest("cantidad de combustible no valido");
            }
        }
        

    }
}











