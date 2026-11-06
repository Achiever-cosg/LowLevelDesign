namespace Factory.Burgers
{
    public class PremiumWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Premium Wheat Burger is being made");
        }
    }
}
