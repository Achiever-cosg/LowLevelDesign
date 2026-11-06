namespace Strategy.SimuDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flywable = new FlyWithWings();
            quackable = new QuackBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I am real Mallard Duck which can fly and quacks...");
        }
    }
}
