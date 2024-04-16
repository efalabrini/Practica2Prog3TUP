namespace Web.Ej3OverrideMethod;
public class Estudiante : Persona
{
    public override string Saludar()
    {
        return "Buen día profesor";
    }
}