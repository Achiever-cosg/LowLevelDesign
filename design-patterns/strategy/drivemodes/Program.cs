namespace Strategy.DriveModes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new SportsVehicle();
            vehicle.Drive();

            vehicle = new OffRoadVehicle();
            vehicle.Drive();

            vehicle = new GoodsVehicle();
            vehicle.Drive();
        }
    }
}
