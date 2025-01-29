// This program was written by: Jacob Boud, Rachel Hansen, Dallen Openshaw, and Sterling Ward

namespace tictactoegroup1_3;
public static class Tools
{
    // Prints the Tic-Tac-Toe board
    public static void PrintBoard(char[] board)
    {
        // loops through every item in the list (board)
        for (int i = 0; i < 9; i++)
        {
            // prints each number from list, .Write because you want them on same line
            Console.Write($" {board[i]} ");
            
            // this ads the | between 1 and 2 and 2 and 3 for each row
            if ((i + 1) % 3 != 0)
            {
                Console.Write("|");
            }
            // this adds the row break between rows 1 and 2 and 2 and 3
            else
            {
                Console.WriteLine();
                if (i < 6)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }
    }

    // Checks if the board is full (for detecting a draw)
    public static bool IsBoardFull(char[] board)
    {
        foreach (char cell in board)
        {
            if (char.IsDigit(cell))
            {
                return false; // If any cell is still a number, the board is not full
            }
        }

        return true;
    }

    // Checks for a winner and returns true if someone won, and the winning symbol ('X' or 'O')
    public static bool isWinner(char[] board)
    {
        bool win = false;

        // Go through all possible winning combinations
        int[][] winningCombinations = new int[][]
        {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 },
            new int[] { 0, 3, 6 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 0, 4, 8 },
            new int[] { 2, 4, 6 }
        };
        
        // Check if character is the same at each position in each combination
        foreach (var combo in winningCombinations)
        {
            if (board[combo[0]] == board[combo[1]] && board[combo[1]] == board[combo[2]] &&
                (board[combo[0]] == 'X' || board[combo[0]] == 'O'))
            {
                Console.WriteLine($"Player {board[combo[0]]} has won the game!");
                win = true;
            }
            else
            {

            }
        }

        if (win == false)
        {
            Console.WriteLine("No winner yet.");
        }

        return win;
    }
}