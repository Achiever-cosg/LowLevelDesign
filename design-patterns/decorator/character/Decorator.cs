namespace Decorator.Character
{
    public abstract class Decorator : Character
    {
        protected Character character;

        public Decorator(Character character)
        {
            this.character = character;
        }
    }
}
