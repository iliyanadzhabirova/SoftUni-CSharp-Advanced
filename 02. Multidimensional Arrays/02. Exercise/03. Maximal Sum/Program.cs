int[] sizes = ReadIntArray();

int rows = sizes[0];
int cols = sizes[1];
int[][] matrix = new int[rows][];
int maxSum=int.MinValue;
int maxRow = 0;
int maxCol = 0;
for (int row = 0; row < rows; row++)
{
    matrix[row] = ReadIntArray();

}
for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                currentSum += matrix[row + i][col + j];
            }
        }
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxRow = row;
            maxCol = col;

        }
    }
}
Console.WriteLine($"Sum = {maxSum}");

for (int row = maxRow; row < maxRow+3; row++)
{
    for (int col = maxCol; col < maxCol+3; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }
    Console.WriteLine();
}
static int[] ReadIntArray()
{
    return Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}