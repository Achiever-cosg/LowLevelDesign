namespace Strategy.SimuDuck
{
    public class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Ducks Squeaks Squeaks");
        }
    }
}
