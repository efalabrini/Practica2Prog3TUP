namespace Web.Ej4
{
    public class PersonajeDeFuerza : Personaje, IMoverse
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = 100;

        }
        public override float CalcularDanio()
        {
            float dañoCalculado = (Fuerza + Agilidad) / Magia;
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
