using Web.Ej3;

namespace Web.Ej3
{
    public class Estudiante : Persona
    {
        
        public string Estudiar()
        {
            return "Estoy estudiando";
        }

        public string MostrarEdad(int edad)
        {
            return $"Mi edad es {edad} años";
        }

        public override string Saludar(string nombre)
        {
            return $"Hola soy el estudiante {nombre}";
        }
        
        public int GetEdad() //agregué un metodo para devolver la edad
        {
            return Edad;
        }
    }
}



