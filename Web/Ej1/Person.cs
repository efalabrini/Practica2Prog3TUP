namespace Practica2Prog3TUP.Ej1
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public string GetName() { return $"Hola! mi nombre es {Name}"; }
    }
}
