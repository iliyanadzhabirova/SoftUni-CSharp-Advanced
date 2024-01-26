Stack<int>delivery=new Stack <int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

int rackCapacity = int.Parse(Console.ReadLine());

int usedRacks = 0;

int currentRackCapacity = rackCapacity;
if (delivery.Any())
{
    usedRacks++;
}

while (delivery.Any())
{
    if (delivery.Peek() <= currentRackCapacity)
    {
        currentRackCapacity-=delivery.Pop();
    }
    else
    {
        usedRacks++;
        currentRackCapacity = rackCapacity;
    }
}
Console.WriteLine(usedRacks);
