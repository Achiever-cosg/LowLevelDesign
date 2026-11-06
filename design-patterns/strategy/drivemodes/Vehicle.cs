namespace Strategy.DriveModes
{
    public class Vehicle
    {
        private IDriveStrategy driveStrategy;

        public Vehicle(IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            this.driveStrategy.Drive();
        }
    }
}
