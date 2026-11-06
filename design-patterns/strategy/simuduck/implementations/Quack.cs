namespace Strategy.SimuDuck
{
    public class QuackBehaviour : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Ducks Quacks");
        }
    }
}
