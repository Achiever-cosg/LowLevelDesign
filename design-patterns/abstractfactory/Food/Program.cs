namespace AbstractFactory.Food
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryCreator creator = new FactoryCreator();

            IFoodFactory factory = creator.GetFactory("HEALTH");
            IGarlicBread bread = factory.GetBread("CLASSIC");
            IBurger burger = factory.GetBurger("CLASSIC");
            bread.Prepare();
            burger.Prepare();

            factory = creator.GetFactory("NORMAL");
            bread = factory.GetBread("CLASSIC");
            burger = factory.GetBurger("CLASSIC");
            bread.Prepare();
            burger.Prepare();
        }
    }
}
