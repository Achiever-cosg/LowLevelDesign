namespace Factory.Burgers
{
    public class SimpleFactory
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
    }
}
