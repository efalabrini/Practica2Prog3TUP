using System.Xml.Linq;

namespace Web.Ej3
{
    public class Teacher: Person
    {
        public Teacher(string name, int age) : base(name, age) { }

        public string Explain()
        {
            return "Estoy explicando";
        }

        public override string Greet()
        {
            return $"Hola soy el profesor {Name}";
        }
    }
}
