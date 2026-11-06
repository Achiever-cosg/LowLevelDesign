namespace Strategy.Payment
{
    public class Crypto : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Implementing Crypto Payments");
        }
    }
}
