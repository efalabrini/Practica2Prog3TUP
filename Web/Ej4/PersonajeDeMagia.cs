using System.Text.Json.Serialization;

namespace Web.Ej4
{
    public class PersonajeDeMagia : Personaje, IMoverse
    {
        [JsonConstructor] //este decorarador indica al deserializador JSON que utilice este constructor
        public PersonajeDeMagia(string nombre, float agilidad, float magia, float fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }

        
        public PersonajeDeMagia(string nombre, float agilidad, float fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = 60;
            Fuerza = fuerza;
        }

        public override float CalcularDanio()
        {
            float dañoCalculado = Fuerza + Agilidad + Magia * 4;
            return dañoCalculado;
        }

        public override string Atacar()
        {
            return $"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia";
        }

        public string MoverseEjeX(string posicion)
        {
            return $"Me movi a la {posicion}";
        }

        public string MoverseEjeY(string posicion)
        {
            return $"Me movi {posicion}";
        }
    }
}
