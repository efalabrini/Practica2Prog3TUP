using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult<string> GetEstudiante([FromQuery] string nombre, [FromQuery] int edad)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.SetEdad(edad);
            return Ok($"{estudiante.Saludar(nombre)}. {estudiante.MostrarEdad(estudiante.GetEdad())}");
        }
        
        
        [HttpGet("[action]")]
        public ActionResult<string> GetProfesor([FromQuery] string nombre, [FromQuery] int edad)
        {
            Profesor profesor = new Profesor();
            profesor.SetEdad(edad);
            return Ok($"{profesor.Saludar(nombre)}. Mi edad es {profesor.GetEdad()}. {profesor.Explicar()}");
        }


    }
}





















