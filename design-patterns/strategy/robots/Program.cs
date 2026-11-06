namespace Strategy.Robots
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Robot companion = new CompanionRobot(new FlyWithWings(), new NormalTalk(), new NormalWalk());
            Robot worker = new WorkerRobot(new FlyWithJet(), new NoWalk(), new NoTalk());

            companion.Projection();
            companion.Fly();
            companion.Talk();
            companion.Walk();

            worker.Projection();
            worker.Fly();
            worker.Walk();
            worker.Talk();
        }
    }
}
