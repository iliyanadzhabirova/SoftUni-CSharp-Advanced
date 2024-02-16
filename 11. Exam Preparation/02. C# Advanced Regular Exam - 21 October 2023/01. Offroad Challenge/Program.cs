using System.Diagnostics.Metrics;

Stack<int> fuel = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Queue<int> consumption = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Queue<int> fuelAmountNeeded = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

int count = 0;
bool hasReachedAny = false;
while (fuel.Any() && consumption.Any())
{
    count++;
    int sum = fuel.Peek() - consumption.Peek();

    if (sum >= fuelAmountNeeded.Peek())
    {
        hasReachedAny = true;
        fuel.Pop();
        consumption.Dequeue();
        fuelAmountNeeded.Dequeue();
        Console.WriteLine($"John has reached: Altitude {count}");
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {count}");
        Console.WriteLine("John failed to reach the top.");
        if (hasReachedAny)
        {
            Console.Write("Reached altitudes: ");

            List<string> altitudes = new List<string>();

            for (int i = 1; i < count; i++)
            {
                altitudes.Add($"Altitude {i}");
            }

            Console.WriteLine(string.Join(", ", altitudes));
        }
        else
        {
            Console.WriteLine("John didn't reach any altitude.");
        }
        return;
    }
    if (fuelAmountNeeded.Count == 0)
    {
        Console.WriteLine($"John has reached all the altitudes and managed to reach the top!");
        return;
    }
}