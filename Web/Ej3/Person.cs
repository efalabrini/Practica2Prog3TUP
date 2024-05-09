namespace Web.Ej3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string nombre)
        {
            Name = nombre;
        }

        public string GetSaludo()
        {
            return $"Hola mi nombre es {Name}";
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
