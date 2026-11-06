namespace AbstractFactory.Food
{
    public class HealthyFoodFactory : IFoodFactory
    {
        public IBurger GetBurger(string type)
        {
            if (type.Equals("VEGIE", StringComparison.OrdinalIgnoreCase))
            {
                return new VegWheatBurger();
            }
            else if (type.Equals("CLASSIC", StringComparison.OrdinalIgnoreCase))
            {
                return new ClassicWheatBurger();
            }
            else if (type.Equals("PREMIUM", StringComparison.OrdinalIgnoreCase))
            {
                return new PremiumWheatBurger();
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
                return new ChesseWheatGarlicBread();
            }
            else if (type.Equals("CLASSIC", StringComparison.OrdinalIgnoreCase))
            {
                return new ClassicWheatGarlicBread();
            }
            else
            {
                throw new ArgumentException("Bread type not supported: " + type);
            }
        }
    }
}
