int[] lines=Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
HashSet<int>firstSet=new HashSet<int>();
HashSet<int> secondSet=new HashSet<int>();

for (int i = 0; i < lines[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0;i < lines[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}

firstSet.IntersectWith(secondSet);

foreach (int i in firstSet)
{
    Console.Write($"{i} ");
}