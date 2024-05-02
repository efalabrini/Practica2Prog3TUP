using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;
using Web.Ej5;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            var vehicle =  new Car();

            return $"{vehicle.Drive()}" +
                $"\nCarga: {vehicle.ChargeFuel(5)} | {vehicle.Fuel} litros fueron cargados al tanque" +
                $"\n{vehicle.Drive()}";
        }
    }
}