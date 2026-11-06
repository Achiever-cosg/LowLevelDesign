namespace Strategy.Robots
{
    public class WorkerRobot : Robot
    {
        public WorkerRobot(IFlyable flyable, IWalkable walkable, ITalkable talkable)
            : base(flyable, walkable, talkable)
        {
        }

        public override void Projection()
        {
            Console.WriteLine("I am worker robot designed to do industrial work");
        }
    }
}
