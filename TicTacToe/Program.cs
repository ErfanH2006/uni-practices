using System;
using System.Drawing;

class Program
{
    static char[,] board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static int turns = 0;
    static char currentPlayer = 'X';

    static void Main(string[] args)
    {

        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        while (true)
        {
            Console.Clear();
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor color = ConsoleColor.DarkGray;
            Console.BackgroundColor = color;
            Console.WriteLine(" the background color is {0}", color);
            DrawBoard();
            PlayerInput();
            if (CheckWin())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nPlayer {currentPlayer} Won");
                break;
            }
            if (turns == 9)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("\nWhat a game ! everything is equal and no one is winner");
                break;
            }
            ChangePlayer();
        }
        Console.WriteLine("\nChoose a button to exit");
        Console.ReadKey();
    }

    static void DrawBoard()
    {
        Console.WriteLine("Tic Tac Toe Game");
        Console.WriteLine();
        Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
    }

    static void PlayerInput()
    {
        int choice;
        bool validInput = false;

        do
        {
            Console.Write($"\nPLayer {currentPlayer} - Chose a movement ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 9)
            {
                int row = (choice - 1) / 3;
                int col = (choice - 1) % 3;

                if (board[row, col] != 'X' && board[row, col] != 'O')
                {
                    board[row, col] = currentPlayer;
                    validInput = true;
                    turns++;
                }
                else
                {
                    Console.WriteLine("This place has already chosen , try another one ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please choose a number between 1 to 9 .");
            }
        } while (!validInput);
    }

    static void ChangePlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool CheckWin()
    {

        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer &&
                board[i, 1] == currentPlayer &&
                board[i, 2] == currentPlayer)
            {
                return true;
            }
            else if (
                board[0, i] == currentPlayer &&
                board[1, i] == currentPlayer &&
                board[2, i] == currentPlayer)
            {
                return true;
            }
            else if (
                board[0, 0] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 2] == currentPlayer)
            {
                return true;
            }
            else if (
                board[0, 2] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 0] == currentPlayer)
            {
                return true;
            }
        }
        return false;
    }
}
