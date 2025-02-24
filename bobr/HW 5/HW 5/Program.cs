using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static Dictionary<char, string> morseCode = new Dictionary<char, string>
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."},
            {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."},
            {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {'0', "-----"},
            {' ', " / "}
        };
        static char[,] board = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        static char player = 'X', computer = '*';
        static Random rand = new Random();

        static void Main(string[] args)
        {
            /*task 1
            Console.WriteLine("Welcome to 'Tic-Tac-Toe'!");
            bool playerStarts = rand.Next(2) == 0;
            Console.WriteLine(playerStarts ? "The player goes first!" : "The computer goes first!");

            while (true)
            {
                PrintBoard();
                if (playerStarts)
                {
                    PlayerMove();
                    if (CheckWin(player)) { PrintBoard(); Console.WriteLine("You win!"); break; }
                    playerStarts = false;
                }
                else
                {
                    ComputerMove();
                    if (CheckWin(computer)) { PrintBoard(); Console.WriteLine("The computer wins!"); break; }
                    playerStarts = true;
                }

                if (IsBoardFull()) { PrintBoard(); Console.WriteLine("It's a draw!"); break; }
            }
        }

        static void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
        }

        static void PlayerMove()
        {
            int move;
            while (true)
            {
                Console.Write("Your move (1-9): ");
                if (int.TryParse(Console.ReadLine(), out move) && move >= 1 && move <= 9 && IsCellEmpty(move))
                {
                    PlaceMove(move, player);
                    break;
                }
                Console.WriteLine("Invalid move, try again.");
            }
        }

        static void ComputerMove()
        {
            int move;
            do { move = rand.Next(1, 10); } while (!IsCellEmpty(move));
            PlaceMove(move, computer);
            Console.WriteLine("The computer chose {0}", move);
        }

        static bool IsCellEmpty(int move)
        {
            int row = (move - 1) / 3, col = (move - 1) % 3;
            return board[row, col] != player && board[row, col] != computer;
        }

        static void PlaceMove(int move, char symbol)
        {
            int row = (move - 1) / 3, col = (move - 1) % 3;
            board[row, col] = symbol;
        }

        static bool CheckWin(char symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol) ||
                    (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol))
                    return true;
            }
            return (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                   (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol);
        }

        static bool IsBoardFull()
        {
            foreach (char c in board)
                if (c != player && c != computer)
                    return false;
            return true;*/

            /*task 3
            Console.WriteLine("Enter text to translate to Morse Code:");
            string input = Console.ReadLine().ToUpper();
            string morseTranslation = TranslateToMorse(input);
            Console.WriteLine("Morse Code:");
            Console.WriteLine(morseTranslation);
            */
        }
        /*for task 3
        static string TranslateToMorse(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (morseCode.ContainsKey(c))
                {
                    result += morseCode[c] + " ";
                }
            }
            return result.Trim();
        }
        */
    }
}
