using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2Prog3TUP.Ej1;

namespace Practica2Prog3TUP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] IList<string> names)
        {
            List<Person> persons = new List<Person>(); 

            foreach (var name in names)
            {
                persons.Add(new Person(name));
            }

            var namesQuery =
                from person in persons
                select person.Name;

            return namesQuery.ToList();
        }

    }
}
