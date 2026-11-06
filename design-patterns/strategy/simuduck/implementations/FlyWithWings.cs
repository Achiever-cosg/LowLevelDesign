namespace Strategy.SimuDuck
{
    public class FlyWithWings : IFlywable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
    }
}
