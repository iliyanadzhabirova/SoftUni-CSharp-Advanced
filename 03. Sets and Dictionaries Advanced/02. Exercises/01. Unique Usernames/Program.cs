int n=int.Parse(Console.ReadLine());
HashSet<string> uniqueUserNames = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    uniqueUserNames.Add(Console.ReadLine());
}

foreach (string uniqueName in uniqueUserNames)
{
    Console.WriteLine(uniqueName);
}