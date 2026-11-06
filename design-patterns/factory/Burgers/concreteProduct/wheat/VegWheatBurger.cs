namespace Factory.Burgers
{
    public class VegWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Veg Wheat Burger is being made");
        }
    }
}
