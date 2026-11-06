namespace Strategy.Robots
{
    public abstract class Robot
    {
        private IFlyable flyable;
        private IWalkable walkable;
        private ITalkable talkable;

        public Robot(IFlyable flyable, IWalkable walkable, ITalkable talkable)
        {
            this.flyable = flyable;
            this.walkable = walkable;
            this.talkable = talkable;
        }

        public abstract void Projection();

        public void Talk()
        {
            talkable.Talk();
        }

        public void Walk()
        {
            walkable.Walk();
        }

        public void Fly()
        {
            flyable.Fly();
        }

        public void SetFlyable(IFlyable flyable)
        {
            this.flyable = flyable;
        }

        public void SetTalkable(ITalkable talkable)
        {
            this.talkable = talkable;
        }

        public void SetWalkable(IWalkable walkable)
        {
            this.walkable = walkable;
        }
    }
}
