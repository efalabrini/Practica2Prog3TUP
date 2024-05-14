namespace Web.Ex1
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name) {
            Name = name;
        }

        public string GetGreet()
        {
            return $"Hola mi nombre es {Name}";
        }
    }
}
