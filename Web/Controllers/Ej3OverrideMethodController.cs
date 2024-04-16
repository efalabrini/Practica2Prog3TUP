
using Microsoft.AspNetCore.Mvc;
using Web.Ej3OverrideMethod;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3OverrideMethodController : ControllerBase
    {
        [HttpGet]
        public List<string> GetSaludoPersonas()
        {
            List<Persona> personas = [];
            personas.Add(new Persona());
            personas.Add(new Profesor());
            personas.Add(new Estudiante());

            List<string> Saludos = [];

            foreach (Persona persona in personas)
            {
                Saludos.Add(persona.Saludar());
            }

            return Saludos;

        }
    }
}
