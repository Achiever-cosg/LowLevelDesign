namespace Strategy.DriveModes
{
    public class GoodsVehicle : Vehicle
    {
        public GoodsVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}
