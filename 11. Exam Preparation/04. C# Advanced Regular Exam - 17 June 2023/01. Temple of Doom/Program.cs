Queue<int> tools = new(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));
Stack<int> substances = new(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));

List<int> challenges = new List<int>(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));

while (tools.Any()&&substances.Any())
{
    int toolValue=tools.Dequeue();
    int substanceValue = substances.Pop();

    int challengeValue = toolValue * substanceValue;

    if (challenges.Contains(challengeValue))
    {
        challenges.Remove(challengeValue);
    }
    else
    {
        toolValue += 1;
        tools.Enqueue(toolValue);
        substanceValue -= 1;
        if (substanceValue>0)
        {
            substances.Push(substanceValue);
        }
    }

}
if (challenges.Count>0)
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else if (challenges.Count==0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}
if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ",tools)}");
}
if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}