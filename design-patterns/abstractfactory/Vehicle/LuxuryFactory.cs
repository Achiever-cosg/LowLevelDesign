namespace AbstractFactory.Vehicle
{
    public class LuxuryFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string carType)
        {
            if (carType.Equals("bmw", StringComparison.OrdinalIgnoreCase))
            {
                return new BMW();
            }
            else if (carType.Equals("mercedes", StringComparison.OrdinalIgnoreCase))
            {
                return new Mercedes();
            }
            else if (carType.Equals("tesla", StringComparison.OrdinalIgnoreCase))
            {
                return new Tesla();
            }
            else
            {
                throw new ArgumentException("Invalid luxury vehicle type: " + carType);
            }
        }
    }
}
