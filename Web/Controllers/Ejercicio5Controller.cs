using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ejercicio5Controller: ControllerBase
    {
        private static List<Car> carsList = new List<Car>();

        [HttpGet("[action]")]
        public ActionResult<string> Drive([FromQuery] int index) 
        {
            try 
            {
                return Ok(carsList[index].Drive());
            }
            catch
            {
                return NotFound();
            }

        }

        [HttpGet("[action]")]
        public ActionResult<List<Car>> GetCars()
        {
            return carsList;
        }

        [HttpPost("[action]")]
        public ActionResult CreateCar([FromBody] Car car) 
        {
            carsList.Add(car);
            return CreatedAtAction(nameof (CreateCar), car);
        }

        [HttpPut("[action]")]
        public ActionResult ChargeFuel([FromBody] int amount, [FromQuery] int index) 
        {
            if (carsList[index] != null) 
            { 
                carsList[index].ChargeFuel(amount);
                return Ok();
            }else
            {
                return NotFound();
            }          
            
        } 

    }
}
