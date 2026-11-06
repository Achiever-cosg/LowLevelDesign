namespace Strategy.SimuDuck
{
    public abstract class Duck
    {
        protected IFlywable flywable = null!;
        protected IQuackable quackable = null!;

        public void Swim()
        {
            Console.WriteLine("Duck is Swimming");
        }

        public void PerformQuack()
        {
            quackable.Quack();
        }

        public void PerformFly()
        {
            flywable.Fly();
        }

        public void SetFlywable(IFlywable flywable)
        {
            this.flywable = flywable;
        }

        public void SetQuackable(IQuackable quackable)
        {
            this.quackable = quackable;
        }

        public abstract void Display();
    }
}
