namespace Web.Ej3
{
    public class Student : Person
    {
        public Student(string nombre) : base(nombre)
        {

        }

        public string Study()
        {
            return "Estoy estudiando";
        }

        public string SeeAge()
        {
            return $"Mi edad es: {Age} años";
        }

        public new string GetSaludo() //new para pisar el metodo de la clase Person
        {
            return $"Hola soy el estudiante {Name}";
        }
    }
}
