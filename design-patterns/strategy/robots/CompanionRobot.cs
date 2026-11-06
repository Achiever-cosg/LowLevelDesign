namespace Strategy.Robots
{
    public class CompanionRobot : Robot
    {
        public CompanionRobot(IFlyable flyable, ITalkable talkable, IWalkable walkable)
            : base(flyable, walkable, talkable)
        {
        }

        public override void Projection()
        {
            Console.WriteLine("I am Companion Robot designed to household needs");
        }
    }
}
