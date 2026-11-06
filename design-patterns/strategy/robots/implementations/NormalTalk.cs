namespace Strategy.Robots
{
    public class NormalTalk : ITalkable
    {
        public void Talk()
        {
            Console.WriteLine("Hello!! How can I help you?");
        }
    }
}
