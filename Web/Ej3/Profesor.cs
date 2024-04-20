using Web.Ej3;

namespace Web.Ej3
{
    public class Profesor : Persona
    {
        
        public string Explicar ()
        {
            return "Estoy explicando";
        }

        public override string Saludar(string nombre)
        {
            return $"Hola soy el profesor {nombre}";
        }

        public int GetEdad()
        {
            return Edad;
        }
    }
}
