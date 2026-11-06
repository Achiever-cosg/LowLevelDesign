namespace Strategy.ActionGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("King");
            King king = new King();
            king.Attack();

            Console.WriteLine("Queen");
            Queen queen = new Queen();
            queen.Attack();
            queen.SetWeaponBehaviour(new SwordBehaviour());
            queen.Attack();
        }
    }
}
