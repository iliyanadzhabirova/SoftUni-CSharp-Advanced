using System.Collections.Generic;

namespace _02.TheGambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;

            int startPositionRow = 0;
            int startPositionCol = 0;

            int amount = 100;

            char ganblerPosition;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];

                    if (data[col] == 'G')
                    {
                        startPositionRow = row;
                        startPositionCol = col;
                    }
                }
            }

            string direction;

            while ((direction = Console.ReadLine()) != "end")
            {
                matrix[startPositionRow, startPositionCol] = '-';

                if (direction == "up")
                {
                    startPositionRow -= 1;
                }
                if (direction == "down")
                {
                    startPositionRow += 1;
                }
                if (direction == "left")
                {
                    startPositionCol -= 1;
                }
                if (direction == "right")
                {
                    startPositionCol += 1;
                }

                char element = matrix[startPositionRow, startPositionCol];

                if (startPositionRow >= rows || startPositionCol >= cols || startPositionRow < 0 || startPositionCol < 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    return;
                }
                else if (amount <= 0)
                {
                    Console.WriteLine("Game over! You lost everything!");
                    return;
                }
                else if (element == '-')
                {
                    matrix[startPositionRow, startPositionCol] = 'G';
                    continue;
                }
                else if (element == 'W')
                {
                    matrix[startPositionRow, startPositionCol] = 'G';
                    amount += 100;
                    continue;
                }
                else if (element == 'P')
                {
                    matrix[startPositionRow, startPositionCol] = 'G';
                    amount -= 200;
                    continue;
                }
                else if (element == 'J')
                {
                    matrix[startPositionRow, startPositionCol] = 'G';
                    amount += 100000;
                    Console.WriteLine("You win the Jackpot!");
                    break;
                }
            }

            if (amount <= 0)
            {
                Console.WriteLine("Game over! You lost everything!");
            }
            else
            {
                Console.WriteLine($"End of the game. Total amount: {amount}$");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}