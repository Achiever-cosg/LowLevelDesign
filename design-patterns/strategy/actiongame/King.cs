namespace Strategy.ActionGame
{
    public class King : Character
    {
        public King() : base(new SwordBehaviour())
        {
        }
    }
}
