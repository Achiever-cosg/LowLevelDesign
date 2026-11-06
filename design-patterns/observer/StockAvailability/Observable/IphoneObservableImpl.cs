namespace Observer.StockAvailability
{
    public class IphoneObservableImpl : IStockObservable
    {
        public int stockCount = 0;
        public List<INotificationAlertObserver> list = new List<INotificationAlertObserver>();

        public void Add(INotificationAlertObserver observer)
        {
            list.Add(observer);
        }

        public void Remove(INotificationAlertObserver observer)
        {
            list.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach (INotificationAlertObserver observer in list)
            {
                observer.Update();
            }
        }

        public void SetStockCount(int newStockAdded)
        {
            if (stockCount == 0)
            {
                NotifySubscribers();
            }
            stockCount += newStockAdded;
        }

        public int GetStockCount()
        {
            return stockCount;
        }
    }
}
