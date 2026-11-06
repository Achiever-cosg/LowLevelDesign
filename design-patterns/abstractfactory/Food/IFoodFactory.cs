namespace AbstractFactory.Food
{
    public interface IFoodFactory
    {
        IBurger GetBurger(string type);
        IGarlicBread GetBread(string type);
    }
}
