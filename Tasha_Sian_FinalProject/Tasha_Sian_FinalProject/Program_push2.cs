namespace Tasha_Sian_FinalProject
{
    internal class Program
    {
        //Board handeling method class
        public class Board
        {
            //inital property declaration 
            public const int Rows = 6;
            public const int Columns = 7;
            public char[,] Grid { get; private set; }

            public Board()
            {
                Grid = new char[Rows, Columns];
                ResetBoard();
            }

            public void ResetBoard()
            {
               for (int r = 0; r < Rows; r++) 
                {
                    for (int c = 0; c < Columns; c++)
                    {
                        //this is out symbol for blank space
                        Grid[r, c] = '#';
                    }
                }
            }
            //this will return the cell collum and row
            public char GetCell(int row, int col)
            {
                return Grid[row, col];
            }

            // cheecking if column is full
            public bool IsColumnFull(int col)
            {
              return Grid[0,col] != '#';
         
            }

            //method to drop the disc onto the board
            public bool DropDisc(int col, char symbol)
            {

            }

            //method for cheecking for a win
            public bool CheckWin(char symbol)
            {

            }

            public bool IsFull()
            {

            }
        }

        //player class 
        public abstract class Player
        {
            //protected player information 
            protected Player(string name, char symbol)
            {

            }

            //get move method
            public abstract int GetMove()
            {

            }

            // current player class

            public class CurrentPlayer : Player
                {
                
                //get move method overide 
                public override int GetMove()
                {

                }
        }

            //board design class

            public class GameBoard
            {
                //method to display the board
                public void displayBoard(Board board)
                {

                }
            }

            //chose play methid
            private void PlayMethod (bool method)
            {
                //methods will go here 
            }

            //game lop
            public void GameLop()
            {
                //lop logic will go here 
            }
        static void Main(string[] args)
        {
           
        }
    }
}
}
