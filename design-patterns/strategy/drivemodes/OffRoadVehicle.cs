namespace Strategy.DriveModes
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SportsDriveStrategy())
        {
        }
    }
}
