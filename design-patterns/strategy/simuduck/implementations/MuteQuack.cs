namespace Strategy.SimuDuck
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("No sound made by Duck");
        }
    }
}
