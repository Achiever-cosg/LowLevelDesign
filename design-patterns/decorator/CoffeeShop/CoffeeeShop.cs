namespace CoffeeShop
{
    public class CoffeeShop
    {
        public static void Main(string[] args)
        {
            ICoffee order1 = new Cappacuno();
            Console.WriteLine($"Order 1: {order1.GetCost()}, {order1.GetDescription()}");

            ICoffee order2 = new MilkDecorator(new SugarDecorator(new Cappacuno()));
            Console.WriteLine($"Order 2: {order2.GetCost()}, {order2.GetDescription()}");

            ICoffee order3 = new SugarDecorator(new MilkDecorator(new SugarDecorator(new Cappacuno())));
            Console.WriteLine($"Order 3: {order3.GetCost()}, {order3.GetDescription()}");
        }
    }
}