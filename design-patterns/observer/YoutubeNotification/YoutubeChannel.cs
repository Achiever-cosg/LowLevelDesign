namespace Observer.YoutubeNotification
{
    public class YoutubeChannel : IObservable
    {
        private List<IObserver> observerList;
        private string name;
        private string latestVideo;

        public YoutubeChannel(string name)
        {
            observerList = new List<IObserver>();
            this.name = name;
            latestVideo = string.Empty;
        }

        public void Subscribe(IObserver observer)
        {
            if (!observerList.Contains(observer))
            {
                observerList.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach (IObserver observer in observerList)
            {
                observer.Update();
            }
        }

        public void UploadVideo(string title)
        {
            latestVideo = title;
            Console.WriteLine(name + " uploaded " + title);
            NotifySubscribers();
        }

        public string GetLatestVideo()
        {
            return " Check our latest video " + latestVideo;
        }
    }
}
