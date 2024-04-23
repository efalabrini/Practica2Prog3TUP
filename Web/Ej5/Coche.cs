namespace Web.Ej5
{
    public class Coche : IVehiculo
    {
        private int gasolina;
        public Coche(int cantidadGasolina) {
            gasolina = cantidadGasolina;
        }

        public string Conducir()
        {
            if (gasolina > 0)
            {
                return "El coche esta conduciendo";
            }
            return "No hay gasolina";

        }

        public bool CargarCombustible(int cantidadCombustible)
        {
            gasolina += cantidadCombustible;
            return true;
        }
    }
}
