namespace Decorator.Coffee
{
    public class VanillaDecorator : CoffeeDecorator
    {
        public VanillaDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + " Vanilla ";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 0.75;
        }
    }
}
