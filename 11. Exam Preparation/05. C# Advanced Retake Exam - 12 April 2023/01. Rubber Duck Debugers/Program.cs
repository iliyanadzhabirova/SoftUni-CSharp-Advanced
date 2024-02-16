Queue<int> time = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> tasks = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int darthVader = 0;
int thor = 0;
int bigBlue = 0;
int smallYellow = 0;

while (time.Any()&&tasks.Any())
{
    int timeValue = time.Dequeue();
    int taskValue = tasks.Pop();
    int result = taskValue * timeValue;

    if (result <0 || result>240)
    {
        taskValue -= 2;
        tasks.Push(taskValue);
        time.Enqueue(timeValue);
    }

    else if (result <=60)
    {
        darthVader++;
    }
    else if (result <= 120)
    {
        thor++;
    }
    else if (result<=180)
    {
        bigBlue++;
    }
    else if (result<=240)
    {
        smallYellow++;
    }
    
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {darthVader}");
Console.WriteLine($"Thor Ducky: {thor}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigBlue}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellow}");

