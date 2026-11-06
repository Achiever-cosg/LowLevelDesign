namespace Observer.YoutubeNotification
{
    public class Program
    {
        public static void Main(string[] args)
        {
            YoutubeChannel channel = new YoutubeChannel("Take You Ahead");

            Subscriber bhanu = new Subscriber(channel, "Bhanu");
            Subscriber aryan = new Subscriber(channel, "Aryan");

            channel.Subscribe(bhanu);
            channel.Subscribe(aryan);

            channel.UploadVideo("LLD Observer Pattern");
            channel.Unsubscribe(aryan);
            channel.UploadVideo("Microsoft Interview Experience");
        }
    }
}
