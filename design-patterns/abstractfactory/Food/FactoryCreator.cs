namespace AbstractFactory.Food
{
    public class FactoryCreator
    {
        public IFoodFactory GetFactory(string type)
        {
            if (type.Equals("HEALTH", StringComparison.OrdinalIgnoreCase))
            {
                return new HealthyFoodFactory();
            }
            else
            {
                return new NormalFoodFactory();
            }
        }
    }
}
