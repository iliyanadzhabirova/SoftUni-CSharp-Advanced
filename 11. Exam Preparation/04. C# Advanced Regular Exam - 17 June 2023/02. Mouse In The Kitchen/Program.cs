namespace _02.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];

            int currentRow = -1;
            int currentCol = -1;
            int cheeseCount = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];

                    if (data[col] == 'M')
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (data[col] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "danger")
            {
                string direction = command;

                int nextRow = currentRow;
                int nextCol = currentCol;

   

                if (direction == "up")
                {
                    nextRow -= 1;
                }
                if (direction == "down")
                {
                    nextRow += 1;
                }
                if (direction == "left")
                {
                    nextCol -= 1;
                }
                if (direction == "right")
                {
                    nextCol += 1;
                }

                if (nextRow >= rows || nextCol >= cols || nextRow < 0 || nextCol < 0)
                {
                    matrix[currentRow, currentCol] = 'M';
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }

                if (matrix[nextRow, nextCol] == '@')
                {
                    continue;
                }

                matrix[currentRow, currentCol] = '*';

                currentRow = nextRow;
                currentCol = nextCol;

                char element = matrix[currentRow, currentCol];

                if (element == 'C')
                {
                    cheeseCount--;
                    matrix[currentRow, currentCol] = '*';

                    if (cheeseCount == 0)
                    {
                        matrix[currentRow, currentCol] = 'M';
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }

                if (element == '*')
                {
                    continue;
                }

                if (element == 'T')
                {
                    matrix[currentRow, currentCol] = 'M';
                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
            }

            if (command == "danger" && cheeseCount > 0)
            {
                Console.WriteLine("Mouse will come back later!");
            }

 
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

/* Option 2
 
  using System.Linq;

namespace MouseInTheKitchen
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] cupboard = new string[dimentions[0], dimentions[1]];
            int mouseRow = -1;
            int mouseCol = -1;
            int totalCheeseNumber = 0;

            for (int i = 0; i < cupboard.GetLength(0); i++)
            {
                string newRow = Console.ReadLine();

                for (int j = 0; j < cupboard.GetLength(1); j++)
                {
                    cupboard[i, j] = newRow[j].ToString();

                    if (newRow[j].ToString() == "M")
                    {
                        mouseRow = i;
                        mouseCol = j;
                        cupboard[mouseRow, mouseCol] = "*";
                    }
                    if (cupboard[i, j] == "C")
                    {
                        totalCheeseNumber++;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                if ((command == "left" && mouseCol == 0) ||
                    (command == "right" && mouseCol == cupboard.GetLength(1) - 1) ||
                    (command == "up" && mouseRow == 0) ||
                    (command == "down" && mouseRow == cupboard.GetLength(0) - 1))
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else
                {
                    if ((command == "left" && cupboard[mouseRow, mouseCol - 1] == "@") ||
                        (command == "right" && cupboard[mouseRow, mouseCol + 1] == "@") ||
                        (command == "up" && cupboard[mouseRow - 1, mouseCol] == "@") ||
                        (command == "down" && cupboard[mouseRow + 1, mouseCol] == "@"))
                    {
                        continue;
                    }
                    else
                    {
                        if (command == "left")
                        {
                            mouseCol--;
                        }
                        else if (command == "right")
                        {
                            mouseCol++;
                        }
                        else if (command == "up")
                        {
                            mouseRow--;
                        }
                        else if (command == "down")
                        {
                            mouseRow++;
                        }

                        if (cupboard[mouseRow, mouseCol] == "C")
                        {
                            totalCheeseNumber--;
                            cupboard[mouseRow, mouseCol] = "*";
                            if (totalCheeseNumber == 0)
                            {
                                cupboard[mouseRow, mouseCol] = "M";
                                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                                break;
                            }
                            continue;
                        }
                        if (cupboard[mouseRow, mouseCol] == "T")
                        {
                            Console.WriteLine("Mouse is trapped!");
                            break;
                        }
                    }
                }
            }
            if (command == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }
            cupboard[mouseRow, mouseCol] = "M";

            for (int i = 0; i < cupboard.GetLength(0); i++)
            {
                for (int j = 0; j < cupboard.GetLength(1); j++)
                {
                    Console.Write(cupboard[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
*/