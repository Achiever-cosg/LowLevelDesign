namespace AbstractFactory.Food
{
    public class VegBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Making Veggie burger");
        }
    }
}
