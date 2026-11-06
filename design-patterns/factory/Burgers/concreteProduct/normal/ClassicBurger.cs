namespace Factory.Burgers
{
    public class ClassicBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Making classic burger!!!");
        }
    }
}
