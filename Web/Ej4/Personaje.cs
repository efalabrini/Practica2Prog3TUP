namespace Web.Ej4
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public float Fuerza { get; set; }
        public float Agilidad { get; set; }
        public float Magia { get; set; }

        public abstract float CalcularDanio();
        public abstract string Atacar();



    }
}