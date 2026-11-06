namespace Observer.StockAvailability
{
    public class MobileAlertObserverImpl : INotificationAlertObserver
    {
        private string userName;
        private IStockObservable observable;

        public MobileAlertObserverImpl(IStockObservable observable, string userName)
        {
            this.observable = observable;
            this.userName = userName;
        }

        public void Update()
        {
            SendMsgOnMobile(userName, "product is in stock, so hurry up");
        }

        private void SendMsgOnMobile(string user, string msg)
        {
            Console.WriteLine("msg sent to " + user);
        }
    }
}
