namespace Web.Ej4
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Enemigo(int vida, int nivel)
        {
            Vida = vida;
            Nivel = nivel;
        }
        public int GetVida()
        {
            return Vida;    
        }
        public int GetNivel()
        {
            return Nivel;
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
