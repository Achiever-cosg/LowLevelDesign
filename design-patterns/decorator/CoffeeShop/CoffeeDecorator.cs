namespace CoffeeShop
{
    public abstract class CoffeeDecoreator : ICoffee
    {
        protected ICoffee coffee;
        public CoffeeDecoreator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public abstract double GetCost();

        public abstract string GetDescription();
    }
}