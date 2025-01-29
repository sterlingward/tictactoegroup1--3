// See https://aka.ms/new-console-template for more information

// Program.cs (Driver Class)
using System;

class Program
{
    static void Main()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Tic-Tac-Toe board
        int player = 1; // Player 1 starts
        int choice;
        bool gameWon = false;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        
        while (!gameWon && !GameLogic.IsBoardFull(board))
        {
            GameLogic.PrintBoard(board);
            Console.Write($"Player {player}, enter a position (1-9): ");

            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] == choice.ToString()[0])
            {
                board[choice - 1] = (player == 1) ? 'X' : 'O';
                gameWon = GameLogic.CheckWinner(board, out char winner);

                if (gameWon)
                {
                    GameLogic.PrintBoard(board);
                    Console.WriteLine($"Player {((winner == 'X') ? 1 : 2)} wins!");
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
            GameLogic.PrintBoard(board);
            Console.WriteLine("It's a draw!");
        }
    }
}
