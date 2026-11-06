namespace TicTacToe
{
    public class Player
    {
        private readonly string name;
        private readonly Symbol symbol;
        public Player(string name, Symbol symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }

        public string GetName() {return name;}
        public Symbol GetSymbol() {return symbol;}

    }
}