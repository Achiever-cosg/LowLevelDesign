namespace Observer.YoutubeNotification
{
    public class Subscriber : IObserver
    {
        private YoutubeChannel channel;
        private string name;

        public Subscriber(YoutubeChannel channel, string name)
        {
            this.channel = channel;
            this.name = name;
        }

        public void Update()
        {
            Console.WriteLine("Hi " + name + this.channel.GetLatestVideo());
        }
    }
}
