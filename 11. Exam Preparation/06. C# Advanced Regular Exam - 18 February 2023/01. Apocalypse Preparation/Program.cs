Queue<int> textile = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> resorces = new Dictionary<string, int>();
resorces.Add("Patch", 0);
resorces.Add("Bandage", 0);
resorces.Add("MedKit", 0);
while (medicaments.Any()&&textile.Any())
{
    int medicamentValue=medicaments.Pop();
    int textileValue = textile.Dequeue();
    int sum=medicamentValue+textileValue;
    
    if (sum==30)
    {
        resorces["Patch"]++;

    }
    else if (sum==40)
    {
        resorces["Bandage"]++;
    }
    else if (sum==100)
    {
        resorces["MedKit"]++;
    }
    else if (sum>100)
    {
        resorces["MedKit"]++;

        int remainingValue = sum - 100 ;
        int newElement = medicaments.Pop() + remainingValue;
        medicaments.Push(newElement);
    }
    else
    {
       medicamentValue += 10;
       medicaments.Push(medicamentValue);
        
    }

}
if (!textile.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textile.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var resource in resorces.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    if (resource.Value > 0)
    {
        Console.WriteLine($"{resource.Key} - {resource.Value}");
    }
}
if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
if (textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}
