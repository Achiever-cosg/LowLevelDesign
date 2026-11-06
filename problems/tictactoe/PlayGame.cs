namespace TicTacToe
{
    public class PlayGame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===>>> TicTacToe Game\n");
            TicTacToeGame game = new TicTacToeGame();
            game.InitializeGame();

            GameStatus gameStatus = game.StartGame();
            switch(gameStatus)
            {
                case GameStatus.DRAW: 
                    Console.WriteLine("Game drawn");
                    break;
                case GameStatus.WIN:
                    Console.WriteLine("Winner");
                    break;
            }
        }
    }
}
