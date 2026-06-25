using System.Reflection.Metadata.Ecma335;

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
               if (col < 0 || col >= Columns || IsColumnFull(col))
                {
                    return false; 
                }
                   
                    //start droping the disk from the bottom and move up
                    for (int r = Rows - 1; r >= 0; r--)
                    {
                        if (Grid[r, col] == '#')
                        {
                            Grid[r,col] = symbol;
                            return true;
                        }
                    }
                return false;
                
            }

            //method for cheecking for a win
            public bool CheckWin(char symbol)
            {
                //check for a win horizontaly
                for (int r = 0; r < Rows; r++)
                {
                    for (int c = 0; c < Columns -3; c++)
                    {
                        if (Grid[r, c] == symbol && Grid[r, c + 1] == symbol && Grid[r, c + 2] == symbol && Grid[r, c + 3] == symbol)
                        {  return true; }

                    }
                }
                //check for a win horizontaly
                for (int r = 0; r< Rows -3; r++)
                {
                    for (int c = 0; c < Columns; c++)
                    {
                        if (Grid[r, c] == symbol && Grid[r + 1, c] == symbol && Grid[r + 2, c] == symbol && Grid[r + 3, c] == symbol)
                        {
                           return true;
                        }
                    }
                }
                //check for win diagonal right
                for (int r = 0; r < Rows - 3; r++)
                {
                    for (int c = 0; c < Columns - 3; c++)
                    {
                        if (Grid[r, c] == symbol && Grid[r + 1, c + 1] == symbol && Grid[r + 2, c + 2] == symbol && Grid[r + 3, c + 3] == symbol)
                        {
                            return true;
                        }
                    }
                }

                //check for win diagonal down right

                for (int r = 3; r < Rows; r++)
                {
                    for (int c = 0; c < Columns - 3; c++)
                    {
                        if (Grid[r, c] == symbol && Grid[r - 1, c + 1] == symbol && Grid[r - 2, c + 2] == symbol && Grid[r - 3, c + 3] == symbol)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public bool IsFull()
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (!IsColumnFull(c)) return false;
                }
                return true;
            }
        }


        //player class 
        public abstract class Player
        {
            //protected player information 

            public string Name { get; protected set; }
            public char Symbol { get; protected set; }
            protected Player(string name, char symbol)
            {
                Name = name;
                Symbol = symbol;
            }

            //get move method
            public abstract int GetMove(Board board, GameBoard view);

        }
            

            // current player class

            public class CurrentPlayer : Player
            {

              public CurrentPlayer(string name, char symbol) : base(name, symbol) { }

              //get move method overide 
              public override int GetMove(Board board, GameBoard view)
                {
                  while (true)
                  {
                      int col = view.GetInteger($"{Name} ({Symbol}), enter column (1-7): ") - 1;

                       if (col >= 0 && col < Board.Columns)
                       {
                           if (!board.IsColumnFull(col))
                           {
                            return col;

                            view.DisplayMessage("That column is full! Try a different one.");
                        }

                        else
                        {
                            view.DisplayMessage("Invalid selection. Column must be between 1 and 7.");
                        }
                            
                       }
                  }
               }
            }

            //board design class

            public class GameBoard
            {
                //method to display the board
                public void displayBoard(Board board)
                {
                Console.Clear();
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
