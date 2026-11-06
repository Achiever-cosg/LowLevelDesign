namespace Observer.YoutubeNotification
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifySubscribers();
    }
}
