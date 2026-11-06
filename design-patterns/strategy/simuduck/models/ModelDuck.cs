namespace Strategy.SimuDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flywable = new FlyWithNoWings();
            quackable = new QuackBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I am Model Duck");
        }
    }
}
