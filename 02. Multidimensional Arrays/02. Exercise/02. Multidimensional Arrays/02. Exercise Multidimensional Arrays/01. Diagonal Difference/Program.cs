int size =int.Parse(Console.ReadLine());

int sumDiagonalOne = 0;
int sumDiagonalTwo = 0;

int[,] matrix = new int[size, size];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] newRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = newRow[col];
        if (row == col)
        {
            sumDiagonalOne += matrix[row, col];
        }
    }
}
for (int row = 0; row < size; row++)
{
    sumDiagonalTwo += matrix[row, size-1-row];
}
Console.WriteLine(Math.Abs(sumDiagonalTwo-sumDiagonalOne));
