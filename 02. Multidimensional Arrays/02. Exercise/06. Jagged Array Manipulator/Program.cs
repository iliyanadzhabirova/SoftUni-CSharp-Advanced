using System.Runtime.ExceptionServices;

int rows =int.Parse(Console.ReadLine());
int[][] jaggedArray= new int[rows][];

for(int row=0; row<jaggedArray.GetLength(0); row++)
{
    jaggedArray[row]=Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}
for (int row = 0; row < jaggedArray.GetLength(0)-1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row+1].Length)
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] *= 2;
            jaggedArray[row + 1][i] *= 2;
        }
       
    }
    else
    {
        for (int i = 0; i < jaggedArray[row].Length; i++)
        {
            jaggedArray[row][i] /= 2;
            
        }
        for (int i = 0; i < jaggedArray[row+1].Length; i++)
        {
            jaggedArray[row+1][i] /= 2;

        }
    }
}
string[] commandTokens=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

while (commandTokens[0]!="End")
{
    if (commandTokens[0]=="Add")
    {
        if (ValidateIndexes(jaggedArray, commandTokens))
        {
            jaggedArray[int.Parse(commandTokens[1])][int.Parse(commandTokens[2])] 
                += int.Parse(commandTokens[3]);
        }
    }
   if (commandTokens[0] == "Subtract")
    {
        if (ValidateIndexes(jaggedArray, commandTokens))
        {
            jaggedArray[int.Parse(commandTokens[1])][int.Parse(commandTokens[2])]
                -= int.Parse(commandTokens[3]);
        }
    }
    commandTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); ;
}
for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}

bool ValidateIndexes(int[][] jaggedArray, string[] commandTokens)
{
    return
         int.Parse(commandTokens[1]) >= 0
         && int.Parse(commandTokens[1]) < jaggedArray.GetLength(0)
         && int.Parse(commandTokens[2]) >= 0
         && int.Parse(commandTokens[2]) < jaggedArray[int.Parse(commandTokens[1])].Length;
}