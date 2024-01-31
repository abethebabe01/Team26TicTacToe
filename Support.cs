using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class SupportClass
    {
        public void PrintBoard(char[] board)
        {
            // Prints Fancy Board
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("- - - - -");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("- - - - -");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }

        public (bool, int) CheckForWin(char[] board, int currentPlayer)
        {
            bool winner = false;

            // Checks for winner by 3 in a row
            if (board[0] == board[1] && board[1] == board[2])
            {
                winner = true;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                winner = true;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                winner = true;
            }

            // Checks for winner by 3 in a column
            if (board[0] == board[3] && board[3] == board[6])
            {
                winner = true;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                winner = true;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                winner = true;
            }

            // Checks for a winner by 3 diagonally
            if (board[0] == board[4] && board[4] == board[8])
            {
                winner = true;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                winner = true;
            }

            // Returns two values in a tuple (one bool, one int)
            // 1. If there is a winner or not 
            // 2. Whose turn it was (if there is a winner, it will be the player who chose last)
            return (winner, currentPlayer);
        }
    }
}