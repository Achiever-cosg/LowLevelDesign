namespace Factory.Vehicles
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                return new Bike();
            }
            else if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else if (type.Equals("Truck", StringComparison.OrdinalIgnoreCase))
            {
                return new Truck();
            }
            else
            {
                throw new ArgumentException("Vehicle Type not supported: " + type);
            }
        }
    }
}
