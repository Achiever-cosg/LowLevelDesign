namespace AbstractFactory.Food
{
    public class ChesseWheatGarlicBread : IGarlicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Cheese Wheat bread in making");
        }
    }
}
