namespace AbstractFactory.Food
{
    public class ClassicWheatBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Classic Wheat Burger is being made");
        }
    }
}
