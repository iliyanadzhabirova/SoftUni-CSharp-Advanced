int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int diagonalSum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    diagonalSum += matrix[i, i];
}

Console.WriteLine(diagonalSum);