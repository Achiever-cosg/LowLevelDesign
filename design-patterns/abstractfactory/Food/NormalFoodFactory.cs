namespace AbstractFactory.Food
{
    public class NormalFoodFactory : IFoodFactory
    {
        public IBurger GetBurger(string type)
        {
            if (type.Equals("VEGIE", StringComparison.OrdinalIgnoreCase))
            {
                return new VegBurger();
            }
            else if (type.Equals("CLASSIC", StringComparison.OrdinalIgnoreCase))
            {
                return new ClassicBurger();
            }
            else if (type.Equals("PREMIUM", StringComparison.OrdinalIgnoreCase))
            {
                return new PremiumBurger();
            }
            else
            {
                throw new ArgumentException("Burger type not supported: " + type);
            }
        }

        public IGarlicBread GetBread(string type)
        {
            if (type.Equals("CHEESE", StringComparison.OrdinalIgnoreCase))
            {
                return new CheeseGarlicBread();
            }
            else if (type.Equals("CLASSIC", StringComparison.OrdinalIgnoreCase))
            {
                return new ClassicGarlicBread();
            }
            else
            {
                throw new ArgumentException("Bread type not supported: " + type);
            }
        }
    }
}
