namespace ChainOfResponsibility.CashDispenser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MoneyHandler handler = new ThousandHandler(3, new FiveHundredHandler(4, new OneHundredHandler(10, null)));

            int amountToWithdraw = 10000;
            handler.Dispense(amountToWithdraw);
        }
    }
}
