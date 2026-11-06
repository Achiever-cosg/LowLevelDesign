using System.ComponentModel;
using System.Reflection.Metadata;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        int size = 3;
        Player? currentPlayer;
        Boolean noWinner = true;
        int freeCells;
        Board gameBoard;
        public TicTacToeGame()
        {
            gameBoard = new Board(size);
        }

        Player? alice, bob;

        public void InitializeGame()
        {
            alice = new Player("alice", Symbol.O);
            bob = new Player("bob", Symbol.X);
            currentPlayer = alice;

            this.gameBoard = new Board(size);
            freeCells = size * size;
            // PrintBoard();
        }

        public void PrintBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    PrintSymbol(gameBoard.getCell(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintSymbol(Symbol symbol)
        {
            switch (symbol)
            {
                case Symbol.X:
                    Console.Write("X      ");
                    break;
                case Symbol.O:
                    Console.Write("O      ");
                    break;
                case Symbol._:
                    Console.Write("_      ");
                    break;
            }
        }

        public GameStatus StartGame()
        {
            while (noWinner)
            {
                PrintBoard();
                Console.Write("Enter your move: ");
                string? userInput = Console.ReadLine();
                string[] indexes = userInput?.Length > 0 ? userInput.Split(',') : [];
                if (freeCells == 0)
                {
                    noWinner = false;
                    return GameStatus.DRAW;
                }

                int row = int.Parse(indexes[0]);
                int col = int.Parse(indexes[1]);

                if (!gameBoard.isValidMove(row, col))
                {
                    Console.WriteLine("invalid move. Please enter again");
                    continue;
                }

                gameBoard.addPiece(row, col, currentPlayer.GetSymbol());
                freeCells--;
                if (gameBoard.checkForWinner(currentPlayer.GetSymbol()))
                {
                    Console.WriteLine($"Game over. {currentPlayer.GetName()}  wins.");
                    noWinner = false;
                    return GameStatus.WIN;
                }
                currentPlayer = (currentPlayer == alice) ? bob : alice;
                Console.WriteLine();
            }

            return GameStatus.WIN;
        }
    }
}