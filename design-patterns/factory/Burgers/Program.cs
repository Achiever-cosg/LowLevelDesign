namespace Factory.Burgers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Simple Factory
            Console.WriteLine("=== Simple Factory ===");
            SimpleFactory simpleFactory = new SimpleFactory();
            IBurger b1 = simpleFactory.GetBurger("CLASSIC");
            b1.Prepare();
            IBurger b2 = simpleFactory.GetBurger("VEGIE");
            b2.Prepare();
            IBurger b3 = simpleFactory.GetBurger("PREMIUM");
            b3.Prepare();

            // Normal Burger Factory (Factory Method)
            Console.WriteLine("\n=== Normal Burger Factory ===");
            IBurgerFactory normalFactory = new NormalBurgerFactory();
            IBurger nb1 = normalFactory.GetBurger("CLASSIC");
            nb1.Prepare();
            IBurger nb2 = normalFactory.GetBurger("VEGIE");
            nb2.Prepare();
            IBurger nb3 = normalFactory.GetBurger("PREMIUM");
            nb3.Prepare();

            // Healthy Burger Factory (Factory Method)
            Console.WriteLine("\n=== Healthy Burger Factory ===");
            IBurgerFactory healthyFactory = new HealthyBurgerFactory();
            IBurger hb1 = healthyFactory.GetBurger("CLASSIC");
            hb1.Prepare();
            IBurger hb2 = healthyFactory.GetBurger("VEGIE");
            hb2.Prepare();
            IBurger hb3 = healthyFactory.GetBurger("PREMIUM");
            hb3.Prepare();
        }
    }
}
