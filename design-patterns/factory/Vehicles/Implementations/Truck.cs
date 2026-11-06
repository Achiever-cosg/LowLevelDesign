namespace Factory.Vehicles
{
    public class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck Starts");
        }

        public void Stop()
        {
            Console.WriteLine("Truck Stops");
        }
    }
}
