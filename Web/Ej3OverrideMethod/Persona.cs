namespace Web.Ej3OverrideMethod;

public class Persona
{
    private int _edad;
    public virtual string Saludar()
    {
        return "Buen día";
    }

    public void SetEdad(int edad)
    {
        _edad = edad;
    }
}
