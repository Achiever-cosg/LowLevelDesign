namespace Factory.Burgers
{
    public class HealthyBurgerFactory : IBurgerFactory
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
    }
}
