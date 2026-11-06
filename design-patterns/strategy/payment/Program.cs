namespace Strategy.Payment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor(new CreditCard());
            paymentProcessor.ProcessPayments();
            paymentProcessor.SetPaymentStrategy(new Crypto());
            paymentProcessor.ProcessPayments();
            paymentProcessor.SetPaymentStrategy(new Stripe());
            paymentProcessor.ProcessPayments();
        }
    }
}
