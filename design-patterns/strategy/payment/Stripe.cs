namespace Strategy.Payment
{
    public class Stripe : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Implementing Stripe Payments");
        }
    }
}
