namespace Observer.StockAvailability
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IStockObservable observable = new IphoneObservableImpl();

            INotificationAlertObserver emailObserver = new EmailAlertObserverImpl(observable, "abc@gmail.com");
            INotificationAlertObserver phoneObserver = new MobileAlertObserverImpl(observable, "Bhanu");
            INotificationAlertObserver phoneObserver2 = new MobileAlertObserverImpl(observable, "Ayush");

            observable.Add(emailObserver);
            observable.Add(phoneObserver);
            observable.Add(phoneObserver2);

            observable.SetStockCount(10);
            observable.SetStockCount(0);
        }
    }
}
