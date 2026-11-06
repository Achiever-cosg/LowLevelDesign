namespace Observer.StockAvailability
{
    public class EmailAlertObserverImpl : INotificationAlertObserver
    {
        private string emailId;
        private IStockObservable observable;

        public EmailAlertObserverImpl(IStockObservable observable, string emailId)
        {
            this.observable = observable;
            this.emailId = emailId;
        }

        public void Update()
        {
            SendEmail(emailId, "Product is in stock, hurry up!!!");
        }

        private void SendEmail(string emailId, string message)
        {
            Console.WriteLine("mail send to " + emailId);
        }
    }
}
