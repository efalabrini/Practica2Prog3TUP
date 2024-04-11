using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult<string> CreatePerson([FromQuery] string name, int age)
        {
            var human1 = new Person(name);
            human1.SetAge(age);

            return human1.GetSaludo();
        }


        [HttpGet("[action]")]
        public ActionResult<string> CreateStudent([FromQuery] string name, int age)
        {
            var human2 = new Student(name);
            human2.SetAge(age);

            return $"{human2.GetSaludo()}\n{human2.SeeAge()}";
        }


        [HttpGet("[action]")]
        public ActionResult<string> CreateProfesor([FromQuery] string name, int age)
        {
            var human3 = new Profesor(name);
            human3.SetAge(age);

            return $"{human3.GetSaludo()}\n{human3.Explain()}";
        }
    }
}