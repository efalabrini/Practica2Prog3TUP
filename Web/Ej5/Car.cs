namespace Web.Ej5
{
    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int initialfuel = 0)
        {
            Fuel = initialfuel; 
        }

        public string Drive()
        {
            if (Fuel > 0)
            {
                return "El coche esta siendo manejado";
            }

            return "El coche no tiene nafta";
        }
        public bool ChargeFuel(int cantFuel)
        {
            Fuel += cantFuel;
            return true;
        }
    }
}
