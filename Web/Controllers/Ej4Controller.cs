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

        [HttpPost("[action]")]
        public ActionResult CreatePersonajeFuerza([FromBody] PersonajeDeFuerza personajeDeFuerza)
        {
            listaPersonajes.Add(personajeDeFuerza);
            return CreatedAtAction(nameof(CreatePersonajeFuerza), personajeDeFuerza);
        }


        [HttpPost("[action]")]
        public ActionResult CreatePersonajeAgilidad([FromBody] PersonajeDeAgilidad personajeDeAgilidad)
        {
            listaPersonajes.Add(personajeDeAgilidad);
            return CreatedAtAction(nameof(CreatePersonajeAgilidad), personajeDeAgilidad);
        }

        [HttpPost("[action]")]
        public ActionResult CreatePersonajeMagia([FromBody] PersonajeDeMagia personajeDeMagia)
        {
            listaPersonajes.Add(personajeDeMagia);
            return CreatedAtAction(nameof(CreatePersonajeMagia), personajeDeMagia);
        }

        [HttpPost("[action]")]
        public ActionResult CreateEnemigo([FromBody] Enemigo enemigo)
        {
            listaEnemigos.Add(enemigo);
            return CreatedAtAction(nameof(CreateEnemigo), enemigo);

        }

        [HttpGet("[action]")]
        public ActionResult<List<string>> GetBatalla()
        {
            List<string> resultadosAtaques = Turno.Atacarse(listaPersonajes);

            Enemigo enemigo = listaEnemigos[0]; // agarro un solo enemigo (el de la lista)
            float dañoTotalPersonajes = 0;

            
            foreach (var personaje in listaPersonajes)
            {
                float daño = personaje.CalcularDanio();
                dañoTotalPersonajes += daño;
            }
            
            enemigo.DañoRecibido(dañoTotalPersonajes); //aplico todo el daño al enemigo

            if (enemigo.Vida <= 0)
            {
                resultadosAtaques.Add($"El enemigo ha sido derrotado porque los personajes hicieron {dañoTotalPersonajes} de daño");
                return resultadosAtaques; 
            }

            resultadosAtaques.Add($"Daño total de los personajes al enemigo: {dañoTotalPersonajes}. El enemigo quedo con {enemigo.Vida} de vida");
            return resultadosAtaques;
        }


    }



}








































