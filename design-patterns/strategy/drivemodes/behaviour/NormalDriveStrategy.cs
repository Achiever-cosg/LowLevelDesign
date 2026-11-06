namespace Strategy.DriveModes
{
    public class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("I have normal Driving Strategy");
        }
    }
}
