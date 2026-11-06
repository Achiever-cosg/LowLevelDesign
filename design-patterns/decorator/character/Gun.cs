namespace Decorator.Character
{
    public class Gun : Decorator
    {
        public Gun(Character ch) : base(ch)
        {
        }

        public override void GetAbilities()
        {
            this.character.GetAbilities();
            Console.Write(" with gun");
        }
    }
}
