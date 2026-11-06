namespace AbstractFactory.Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVehicleFactory factory = VehicleFactoryProvider.GetFactory(true);
            IVehicle v1 = factory.CreateVehicle("tesla");
            v1.Average();

            factory = VehicleFactoryProvider.GetFactory(false);
            v1 = factory.CreateVehicle("hyundai");
            v1.Average();
        }
    }
}
