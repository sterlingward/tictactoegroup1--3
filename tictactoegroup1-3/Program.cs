// See https://aka.ms/new-console-template for more information
// This program was written by: Jacob Boud, Rachel Hansen, Dallen Openshaw, and Sterling Ward
// Program.cs (Driver Class)
using System;
namespace tictactoegroup1_3;
class Program
{
    static void Main()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Tic-Tac-Toe board
        int player = 1; // Player 1 starts
        int choice;
        bool gameWon = false;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        
        while (!gameWon && !Tools.IsBoardFull(board))
        {
            Tools.PrintBoard(board);
            Console.Write($"Player {player}, enter a position (1-9): ");

            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] == choice.ToString()[0])
            {
                board[choice - 1] = (player == 1) ? 'X' : 'O';
                gameWon = Tools.isWinner(board );

                if (gameWon)
                {
                    Tools.PrintBoard(board);
                    break;
                }
                player = (player == 1) ? 2 : 1; // Switch player
            }
            else
            {
                Console.WriteLine("Invalid move. Try again.");
            }
        }

        if (!gameWon)
        {
            Tools.PrintBoard(board);
            Console.WriteLine("It's a draw!");
        }
    }
}
