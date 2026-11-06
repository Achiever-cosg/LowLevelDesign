namespace Strategy.Payment
{
    public class CreditCard : IPaymentStrategy
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Implementing Credit Card Payments");
        }
    }
}
