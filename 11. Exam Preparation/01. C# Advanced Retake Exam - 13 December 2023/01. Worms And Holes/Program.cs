using System.ComponentModel.Design;

Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int matchesCount = 0;
int wormsCount = worms.Count;
while (worms.Any() && holes.Any())
{
    int wormValue = worms.Peek();
    int holeValue = holes.Peek();

    if (holeValue == wormValue)
    {
        worms.Pop();
        holes.Dequeue();
        matchesCount++;
    }
    else
    {
        holes.Dequeue();

        int newWormValue = worms.Peek() - 3;
        worms.Pop();
        worms.Push(newWormValue);
        if (worms.Peek() <= 0)
        {
            worms.Pop();
        }
    }
}
if (matchesCount > 0)
{
    Console.WriteLine($"Matches: {matchesCount}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if (!worms.Any() && wormsCount == matchesCount)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (!worms.Any())
{
    Console.WriteLine("Worms left: none");
}
else if (worms.Any())
{
    Console.WriteLine($"Worms left: {String.Join(", ", worms)}");
}

if (holes.Any())
{
    Console.WriteLine($"Holes left: {String.Join(", ", holes)}");
}
else
{
    Console.WriteLine("Holes left: none");
}