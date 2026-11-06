namespace AbstractFactory.Food
{
    public class ClassicGarlicBread : IGarlicBread
    {
        public void Prepare()
        {
            Console.WriteLine("Classic bread in making");
        }
    }
}
