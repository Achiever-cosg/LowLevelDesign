using System.Collections.Concurrent;
using System.Data;

namespace TicTacToe
{
    public class Board
    {
        private int size;
        private Symbol[,] playingBoard;

        public Board(int size)
        {
            this.size = size;
            playingBoard = new Symbol[size, size];
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    playingBoard[i, j] = Symbol._;
                }
            }
        }

        public bool isValidMove(int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size && playingBoard[row, col] == Symbol._;
        }

        public void addPiece(int row, int col, Symbol symbol)
        {
            playingBoard[row, col] = symbol;
        }

        public Symbol getCell(int row, int col)
        {
            return playingBoard[row, col];
        }

        public bool checkForWinner(Symbol symbol)
        {
            bool isWinner = true;
            // check for rows
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (playingBoard[i, j] != symbol)
                    {
                        isWinner = false;
                    }
                }
                if (isWinner)
                {
                    return true;
                }
            }

            // check for columns
            for (int i = 0; i < size; i++)
            {
                isWinner = true;
                for (int j = 0; j < size; j++)
                {
                    if (playingBoard[j, i] != symbol)
                    {
                        isWinner = false;
                    }
                }
                if (isWinner)
                {
                    return true;
                }
            }

            // check for diagonals
            for (int i = 0; i < size; i++)
            {
                isWinner = true;
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        if (playingBoard[i, j] != symbol)
                        {
                            isWinner = false;
                        }
                    }
                }
            }

            if (isWinner)
            {
                return true;
            }

            for (int i = 0; i < size; i++)
            {
                isWinner = true;
                for (int j = 0; j < size; j++)
                {
                    if (i + j == size - 1)
                    {
                        if (playingBoard[i, j] != symbol)
                        {
                            isWinner = false;
                        }
                    }
                }
            }

            if (isWinner)
            {
                return true;
            }

            return false;
        }
    }
}