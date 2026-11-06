namespace Strategy.Robots
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Robot flies with wings");
        }
    }
}
