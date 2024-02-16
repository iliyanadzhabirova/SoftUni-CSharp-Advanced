using System.Drawing;

int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
char[,] matrix = new char[dimensions[0], dimensions[1]];

int startingRow = 0;
int startingCol = 0;
for (int row = 0; row < dimensions[0]; row++)
{
    char[] rowValues = Console.ReadLine().ToCharArray();
    for (int col = 0; col < dimensions[1]; col++)
    {
        matrix[row, col] = rowValues[col];
        if (rowValues[col] == 'B')
        {
            startingRow = row;
            startingCol = col;
        }
    }

}
int initialRow = startingRow;
int initialCol = startingCol;

string direction;

while (true)
{
    direction = Console.ReadLine();

    int nextPositionRow = startingRow;
    int nextPositionCol = startingCol;


    if (direction == "up")
    {
        nextPositionRow -= 1;
    }
    if (direction == "down")
    {
        nextPositionRow += 1;
    }
    if (direction == "left")
    {
        nextPositionCol -= 1;
    }
    if (direction == "right")
    {
        nextPositionCol += 1;
    }

    if (nextPositionRow >= dimensions[0] || nextPositionCol >= dimensions[1] || nextPositionRow < 0 || nextPositionCol < 0)
    {
        Console.WriteLine("The delivery is late. Order is canceled.");
        matrix[initialRow, initialCol] = ' ';
        break;
    }

    if (matrix[nextPositionRow, nextPositionCol] == '*')
    {
        continue;
    }
    startingRow = nextPositionRow;
    startingCol = nextPositionCol;

    char element = matrix[nextPositionRow, nextPositionCol];

    if (element == 'A')
    {
        matrix[startingRow, startingCol] = 'P';
        Console.WriteLine("Pizza is delivered on time! Next order...");
        break;
    }
    else if (element == 'P')
    {
        matrix[startingRow, startingCol] = 'R';
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        continue;
    }
    else if (element == '-')
    {
        matrix[startingRow, startingCol] = '.';
        continue;
    }
}
for (int i = 0; i < dimensions[0]; i++)
{
    for (int j = 0; j < dimensions[1]; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}

