namespace Web.Ej5
{
    public interface IVehicle
    {
        int Fuel { get; set; }
        string Drive();
        bool ChargeFuel(int fuel);
    }
}
