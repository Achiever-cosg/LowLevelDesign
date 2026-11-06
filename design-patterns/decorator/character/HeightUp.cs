namespace Decorator.Character
{
    public class HeightUp : Decorator
    {
        public HeightUp(Character character) : base(character)
        {
        }

        public override void GetAbilities()
        {
            character.GetAbilities();
            Console.Write(" with height up ");
        }
    }
}
