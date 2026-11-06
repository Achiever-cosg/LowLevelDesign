namespace Factory.Vehicles
{
    public class Bike : IVehicle
    {
        public void Start() {
            Console.WriteLine("Bike Starts");
        }

        public void Stop() {
            Console.WriteLine("Bike Stops");
        }
    }
}
