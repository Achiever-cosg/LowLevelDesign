namespace Decorator.Coffee
{
    public class Cappuccino : ICoffee
    {
        public string GetDescription()
        {
            return "Cappuccino";
        }

        public double GetCost()
        {
            return 3.00;
        }
    }
}
