namespace Web.Ej4
{
    public static class Turno
    {
        public static List<string> Atacarse(IList<Personaje> personajes)
        {
            List<string> resultadosAtaques = new List<string>();

            foreach (var personaje in personajes)
            {
                string resultadoAtaque = personaje.Atacar();
                resultadosAtaques.Add(resultadoAtaque);
            }
            return resultadosAtaques; //devuelve una lista de strings para luego mostrarla en el endpoint (batalla)

        }
        public static void MoverFichas(IMoverse ficha, string direccionX, string direccionY)
        {
            ficha.MoverseEjeX(direccionX);
            ficha.MoverseEjeY(direccionY);
        }

    }
}
