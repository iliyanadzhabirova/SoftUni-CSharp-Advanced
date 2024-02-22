int n = int.Parse(Console.ReadLine());
char[,] airSpace = new char[n, n];
int airRow = 0;
int airCol = 0;
int enemiesCounter = 0;
int armorValue = 300;
for (int row = 0; row < n; row++)
{
    char[] data = Console.ReadLine().ToCharArray();
    for (int col = 0; col < n; col++)
    {
        airSpace[row, col] = data[col];
        if (airSpace[row, col] == 'J')
        {
            airRow = row;
            airCol = col;
            airSpace[airRow, airCol] = '-';
        }
        if (airSpace[row, col] == 'E')
        {
           enemiesCounter++;
        }
    }
}
string command;
while (true) 
{
command = Console.ReadLine();

    if (command == "left")
    {
        airCol--;
    }
    else if (command == "right")
    {
        airCol++;
    }
    else if (command == "up")
    {
        airRow--;
    }
    else if (command == "down")
    {
        airRow++;
    }

    if (airSpace[airRow,airCol]=='-')
    {
        continue;
    }
    if (airSpace[airRow, airCol] == 'E')
    {
        airSpace[airRow, airCol] = '-';
        enemiesCounter--;
        armorValue -= 100;
        if (armorValue<=0)
        {
            airSpace[airRow, airCol] = 'J';
            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{airRow}, {airCol}]!");
            break;
        }
        if(enemiesCounter == 0)
        {
            airSpace[airRow, airCol] = 'J';
            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            break;
        }
    }
    if (airSpace[airRow, airCol] == 'R')
    {
        armorValue = 300;
        airSpace[airRow, airCol] = '-';
        
    }

}
for (int i = 0; i < airSpace.GetLength(0); i++)
{
    for (int j = 0; j < airSpace.GetLength(1); j++)
    {
        Console.Write(airSpace[i, j]);
    }
    Console.WriteLine();
}