namespace Factory.Burgers
{
    public class PremiumBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Making premium Burger");
        }
    }
}
