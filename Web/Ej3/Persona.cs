namespace Web.Ej3
{
    public abstract class Persona
    {
        protected int Edad { get; set; }
        public abstract string Saludar(string nombre); //este metodo lo marqué como abstracto para que se implemente en clases hijas

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
        
        
        
    }
}


