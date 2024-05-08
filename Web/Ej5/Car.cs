namespace Web.Ej5
{
    public class Car : IVehicle
    {
        
        public Car(int fuel)
        {

        }

        public int Fuel { get ; set ; }

        public bool ChargeFuel(int fuel)
        {
            Fuel = fuel;
            return true;
        }

        public string Drive()
        {
            if (Fuel > 0) 
            {
                return "conduciendo";
            }else {
                return "no hay nafta";
            }
        }
    }
}
