using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();

        [HttpGet("[action]")]
        public ActionResult<string> GetPersonajeFuerza([FromQuery] string nombre, [FromQuery] int agilidad, [FromQuery] int magia)
        {
            PersonajeDeFuerza pFuerza = new PersonajeDeFuerza(nombre, agilidad, magia);
            listaPersonajes.Add(pFuerza);   
            return "Creaste un personaje de fuerza";

        }

        [HttpGet("[action]")]
        public ActionResult<string> GetPersonajeAgilidad([FromQuery] string nombre, [FromQuery] int agilidad, [FromQuery] int magia, [FromQuery] int fuerza)
        {
            PersonajeDeAgilidad pAgilidad = new PersonajeDeAgilidad(nombre, agilidad, magia, fuerza);
            listaPersonajes.Add (pAgilidad);
            return "Creaste un personaje de agilidad";
        }

        [HttpGet("[action]")]
        public ActionResult<string> GetPersonajeMagia([FromQuery] string nombre, [FromQuery] int agilidad, [FromQuery] int magia, [FromQuery] int fuerza)
        {
            PersonajeDeMagia pMagia = new PersonajeDeMagia(nombre, agilidad, magia, fuerza);
            listaPersonajes.Add(pMagia);
            return "Creaste un personaje de agilidad";
        }

        [HttpGet("[action]")]
        public ActionResult<string> GetEnemigo([FromQuery] int vida, [FromQuery] int nivel)
        {
            Enemigo enemigo = new Enemigo(vida, nivel);
            listaEnemigos.Add(enemigo);
            return $"Creaste un enemigo con vida {enemigo.GetVida()} y nivel {enemigo.GetNivel()}";

        }

        [HttpGet("[action]")]
        public ActionResult<List<string>> GetBatalla()
        {
            List<string> resultadosAtaques = Turno.Atacarse(listaPersonajes);
            return resultadosAtaques;
        }

    }
}




















