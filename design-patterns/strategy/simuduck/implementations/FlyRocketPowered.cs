namespace Strategy.SimuDuck
{
    public class FlyRocketPowered : IFlywable
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with rocket");
        }
    }
}
