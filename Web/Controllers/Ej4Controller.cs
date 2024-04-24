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
        public ActionResult<string> GetPersonajeFuerza([FromQuery] string nombre, [FromQuery] float agilidad, [FromQuery] float magia)
        {
            PersonajeDeFuerza pFuerza = new PersonajeDeFuerza(nombre, agilidad, magia);
            listaPersonajes.Add(pFuerza);   
            return $"Creaste un personaje de fuerza llamado {nombre} con {agilidad} de agilidad y {magia} de magia";

        }

        [HttpGet("[action]")]
        public ActionResult<string> GetPersonajeAgilidad([FromQuery] string nombre, [FromQuery] float agilidad, [FromQuery] float magia, [FromQuery] float fuerza)
        {
            PersonajeDeAgilidad pAgilidad = new PersonajeDeAgilidad(nombre, agilidad, magia, fuerza);
            listaPersonajes.Add (pAgilidad);
            return $"Creaste un personaje de agilidad llamado {nombre} con {agilidad} de agilidad, {magia} de magia y {fuerza} de fuerza";
        }

        [HttpGet("[action]")]
        public ActionResult<string> GetPersonajeMagia([FromQuery] string nombre, [FromQuery] float agilidad, [FromQuery] float magia, [FromQuery] float fuerza)
        {
            PersonajeDeMagia pMagia = new PersonajeDeMagia(nombre, agilidad, magia, fuerza);
            listaPersonajes.Add(pMagia);
            return $"Creaste un personaje de magia llamado {nombre} con {agilidad} de agilidad, {magia} de magia y {fuerza} de fuerza";
        }

        [HttpGet("[action]")]
        public ActionResult<string> GetEnemigo([FromQuery] float vida, [FromQuery] int nivel)
        {
            Enemigo enemigo = new Enemigo(vida, nivel);
            listaEnemigos.Add(enemigo);
            return $"Creaste un enemigo con vida {enemigo.GetVida()} y nivel {enemigo.GetNivel()}";

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








































