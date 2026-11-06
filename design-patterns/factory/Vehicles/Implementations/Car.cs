namespace Factory.Vehicles
{
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Starts");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stops");
        }
    }
}
