namespace Web.Ej4
{
    public class PersonajeDeAgilidad : Personaje, IMoverse
    {
        public PersonajeDeAgilidad(string nombre, float agilidad, float magia, float fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;

        }

        public override float CalcularDanio()
        {
            float dañoCalculado = Fuerza / 2 * Agilidad * Magia / 2;
            return dañoCalculado;
        }
        public override string Atacar()
        {
            return $"{Nombre} hizo {CalcularDanio()} de daño";

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