using System; 
// The purpose of this program is to simulate tic tac toe for friends and family to play
// section 02
// Chris Fowler, Rachel Yorke, Abe Lamoreaux, Mitch Brammer.
namespace TicTacToe;
class TicTacToe
{
    static char[] board = [ '1', '2', '3', '4', '5', '6', '7', '8', '9' ]; // we decided to hard corde this because it doesn't need to scale and it's easier for players to read.
    static int currentPlayer = 1; // Player 1 starts
    static bool gameOver = false; // This ends the loop if it becomes true.
    static void Main(string[] args)
    {
        SupportClass sc = new SupportClass();
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        sc.PrintBoard(board);

        while (!gameOver)
        {
            Console.WriteLine("Player " + currentPlayer + "'s turn");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()); //We are finding where they want to put their mark in the tic tac boxes.

            if (choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            //Setting the player to either x's or o's
            char symbol;
            if (currentPlayer == 1)
            {
                symbol = 'X';
            }
            else
            {
                symbol = 'O';
            }

            //this prints their choice to the board
            board[choice - 1] = symbol;

            sc.PrintBoard(board);

            //Check if the game is over because of a win or a tie
            if (sc.CheckForWin(board, currentPlayer).Item1) 
            {
                Console.WriteLine("Player " + currentPlayer + " wins!");
                gameOver = true;
            }
            else if (CheckForDraw())
            {
                Console.WriteLine("It's a draw! Play again soon!");
                gameOver = true;
            }

            // Switch players to print into boxes
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }
        }
    }

    //I kept this in the driver class because someone has to do it!
    static bool CheckForDraw()
    {
        // Check if the board is full
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false; // There is an empty cell, game is not tied yet!
        }
        return true; // Stalemate, everything filled!
    }
}
