namespace Factory.Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVehicle v1 = VehicleFactory.GetVehicle("Bike");
            v1.Start();
            v1.Stop();

            IVehicle v2 = VehicleFactory.GetVehicle("Truck");
            v2.Start();
            v2.Stop();

            IVehicle v3 = VehicleFactory.GetVehicle("Car");
            v3.Start();
            v3.Stop();
        }
    }
}
