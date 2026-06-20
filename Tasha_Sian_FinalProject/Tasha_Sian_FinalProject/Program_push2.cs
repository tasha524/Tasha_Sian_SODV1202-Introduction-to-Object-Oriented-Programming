namespace Tasha_Sian_FinalProject
{
    internal class Program
    {
        //Board handeling method class
        public class Board
        {
            //logic for the board

            //method plans

            //to reset the board
            public void ResetBoard()
            {
                //logic will go here
            }

            // cheecking if column is full
            public bool IsColumnFull(int col)
            {

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
