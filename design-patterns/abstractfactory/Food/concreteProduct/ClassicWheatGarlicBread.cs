namespace AbstractFactory.Food
{
    public class ClassicWheatGarlicBread : IGarlicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Classic Wheat bread in making");
        }
    }
}
