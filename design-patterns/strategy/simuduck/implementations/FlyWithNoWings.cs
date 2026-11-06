namespace Strategy.SimuDuck
{
    public class FlyWithNoWings : IFlywable
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly!!!");
        }
    }
}
