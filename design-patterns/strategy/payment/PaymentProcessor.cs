namespace Strategy.Payment
{
    public class PaymentProcessor
    {
        private IPaymentStrategy paymentStrategy;

        public PaymentProcessor(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void ProcessPayments()
        {
            this.paymentStrategy.ProcessPayment();
        }
    }
}
