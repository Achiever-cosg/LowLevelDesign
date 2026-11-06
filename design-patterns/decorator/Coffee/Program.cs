namespace Decorator.Coffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICoffee coffee = new Espresso();
            coffee = new MilkDecorator(coffee);
            coffee = new VanillaDecorator(coffee);
            Console.WriteLine(" Order : " + coffee.GetDescription());
            Console.WriteLine(" Cost : " + coffee.GetCost());

            ICoffee another = new Cappuccino();
            another = new SugarDecorator(another);
            Console.WriteLine(" Order : " + another.GetDescription());
            Console.WriteLine(" Cost : " + another.GetCost());
        }
    }
}
