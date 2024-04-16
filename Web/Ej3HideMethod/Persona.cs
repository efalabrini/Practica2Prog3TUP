namespace Web.Ej3HideMethod;

public class Persona
{
    private int _edad;
    public string Saludar()
    {
        return "Buen día";
    }

    public void SetEdad(int edad)
    {
        _edad = edad;
    }
}
