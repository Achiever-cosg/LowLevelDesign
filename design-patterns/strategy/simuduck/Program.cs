namespace Strategy.SimuDuck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.PerformFly();
            duck.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlywable(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
