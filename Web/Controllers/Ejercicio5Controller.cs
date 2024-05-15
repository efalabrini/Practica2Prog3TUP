using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ejercicio5Controller: ControllerBase
    {
        private Car tesla;
        public Ejercicio5Controller() 
        {
            tesla = new Car(0);
        }

        [HttpGet("[action]")]
        public ActionResult<string> Drive() 
        {
            return tesla.Drive();
        }
    }
}
