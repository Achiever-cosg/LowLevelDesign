namespace Strategy.Robots
{
    public class NoTalk : ITalkable
    {
        public void Talk()
        {
            Console.WriteLine("No talk allowed");
        }
    }
}
