namespace Strategy.Robots
{
    public class NoWalk : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Sorry you need to move me!! I can't walk");
        }
    }
}
