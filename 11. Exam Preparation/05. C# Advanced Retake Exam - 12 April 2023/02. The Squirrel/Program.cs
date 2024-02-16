int n = int.Parse(Console.ReadLine());
string[] directions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
char[,] matrix = new char[n, n];
int currentRow = 0;
int currentCol = 0;
int hazelNuts = 0;
for (int row = 0; row < n; row++)
{
    char[] data = Console.ReadLine().ToCharArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = data[col];
        if (matrix[row, col] == 's')
        {
            currentRow = row;
            currentCol = col;
        }

    }
}
string direction;
for (int i = 0; i < directions.Length; i++)
{
    direction = directions[i];

    if ((direction == "left" && currentCol == 0) ||
                    (direction == "right" && currentCol == matrix.GetLength(1) - 1) ||
                    (direction == "up" && currentRow == 0) ||
                    (direction == "down" && currentRow == matrix.GetLength(0) - 1))
    {
        Console.WriteLine("The squirrel is out of the field.");
        Console.WriteLine($"Hazelnuts collected: {hazelNuts}");
        return;
    }

    else
    {
        if (direction == "left")
        {
            currentCol--;
        }
        else if (direction == "right")
        {
            currentCol++;
        }
        else if (direction == "up")
        {
            currentRow--;
        }
        else if (direction == "down")
        {
            currentRow++;
        }

        if (matrix[currentRow, currentCol] == 'h')
        {
            hazelNuts++;
            matrix[currentRow, currentCol] = 's';
            if (hazelNuts == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                break;
            }
            continue;
        }

        if (matrix[currentRow, currentCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelNuts}");
            return;
        }
    }
}

if (hazelNuts > 0 && hazelNuts < 3)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {hazelNuts}");