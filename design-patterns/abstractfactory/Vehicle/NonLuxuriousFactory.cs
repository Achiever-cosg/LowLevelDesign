namespace AbstractFactory.Vehicle
{
    public class NonLuxuriousFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string carType)
        {
            if (carType.Equals("hyundai", StringComparison.OrdinalIgnoreCase))
            {
                return new Hyundai();
            }
            else if (carType.Equals("swift", StringComparison.OrdinalIgnoreCase))
            {
                return new Swift();
            }
            else
            {
                throw new ArgumentException("Invalid non-luxury vehicle type: " + carType);
            }
        }
    }
}
