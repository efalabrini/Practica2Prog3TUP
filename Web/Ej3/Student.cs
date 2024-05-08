namespace Web.Ej3
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age) { }
        public string ShowAge()
        {
            return $"Mi edad es: {Age} años";
        }

        public string Study()
        {
            return "Estoy estudiando";
        }

        public override string Greet(){
            return $"Hola soy el estudiante {Name}";
        }
    }
}
