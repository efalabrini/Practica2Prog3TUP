namespace Web.Ej3
{
    public abstract class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public abstract string Greet();

        public void SetAge(int age) {
            Age = age;
        }
    }
}
