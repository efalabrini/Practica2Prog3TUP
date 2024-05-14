
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web.Ex1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ex1Controller : ControllerBase
    {

        [HttpGet()]
        public List<string> Get([FromQuery] string person1, [FromQuery] string person2, [FromQuery] string person3 )
        {
            List<Person> list = [];
            list.Add(new Person(person1));
            list.Add(new Person(person2));
            list.Add(new Person(person3));

            List<string> result = [];

            foreach (Person person in list)
            {
                result.Add(person.GetGreet());
            }

            return result;
        }
    }



}