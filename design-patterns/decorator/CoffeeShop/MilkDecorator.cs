namespace CoffeeShop
{
    public class MilkDecorator : CoffeeDecoreator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) {}

        public override double GetCost()
        {
            return coffee.GetCost() + 10.00;
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", milk";
        }
    }
}