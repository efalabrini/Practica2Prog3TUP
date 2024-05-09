namespace Web.Ej3
{
    public class Profesor : Person
    {
        public Profesor(string nombre) : base(nombre)
        {
           
        }

        public string Explain()
        {
            return "Estoy explicando";
        }

        public new string GetSaludo() //new para pisar el metodo de la clase Person
        {
            return $"Hola soy el profesor {Name}";
        }
    }
}
