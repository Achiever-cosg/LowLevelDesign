namespace AbstractFactory.Food
{
    public class CheeseGarlicBread : IGarlicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Cheese bread in making");
        }
    }
}
