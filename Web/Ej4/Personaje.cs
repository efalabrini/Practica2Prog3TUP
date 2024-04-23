namespace Web.Ej4
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract float CalcularDanio();
        public abstract string Atacar();



    }
}