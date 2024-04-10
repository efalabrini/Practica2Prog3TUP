using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            var human1 = new Person("Juanito Flores");

            var human2 = new Student("Julian Gonzales");
            human2.SetAge(19);

            var human3 = new Profesor("Miguelito Ramirez");
            human3.SetAge(46);

            return $"Persona:\n{human1.GetSaludo()}\n\nEstudiante:\n{human2.GetSaludo()}\n{human2.SeeAge()}\n\nProfesor:\n{human3.GetSaludo()}\n{human3.Explain()}";
        }
    }
}