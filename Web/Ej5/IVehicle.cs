namespace Web.Ej5
{
    public interface IVehicle
    {
        int Fuel { get; set; }
        void Drive();
        bool ChargeFuel(int fuel);
    }
}
