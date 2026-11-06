namespace Decorator.Coffee
{
    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetCost()
        {
            return 2.00;
        }
    }
}
