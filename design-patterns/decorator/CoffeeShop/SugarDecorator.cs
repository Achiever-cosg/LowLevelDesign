namespace CoffeeShop
{
    public class SugarDecorator : CoffeeDecoreator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) {}

        public override double GetCost()
        {
            return coffee.GetCost() + 15.00;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", sugar";
        }
    }
}