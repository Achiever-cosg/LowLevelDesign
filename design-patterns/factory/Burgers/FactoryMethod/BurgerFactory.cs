namespace Factory.Burgers
{
    public interface IBurgerFactory
    {
        IBurger GetBurger(string type);
    }
}
