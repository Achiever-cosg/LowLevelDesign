namespace Strategy.DriveModes
{
    public class SportsVehicle : Vehicle
    {
        public SportsVehicle() : base(new SportsDriveStrategy())
        {
        }
    }
}
