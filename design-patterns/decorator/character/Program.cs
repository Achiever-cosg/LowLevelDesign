namespace Decorator.Character
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character character = new Mario();
            character.GetAbilities();

            character = new HeightUp(character);
            character.GetAbilities();

            character = new Gun(character);
            character.GetAbilities();
        }
    }
}
