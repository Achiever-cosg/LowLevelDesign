namespace Observer.StockAvailability
{
    public interface IStockObservable
    {
        void Add(INotificationAlertObserver observer);
        void Remove(INotificationAlertObserver observer);
        void NotifySubscribers();
        void SetStockCount(int newStockAdded);
        int GetStockCount();
    }
}
