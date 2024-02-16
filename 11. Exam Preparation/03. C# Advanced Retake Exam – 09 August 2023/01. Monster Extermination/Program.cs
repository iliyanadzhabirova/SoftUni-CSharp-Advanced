Queue<int> monsters = new(Console.ReadLine()
               .Split(",", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));

Stack<int> soldiers = new(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int count = 0;
while (monsters.Any() && soldiers.Any())
{
    int armour = monsters.Dequeue();
    int strike = soldiers.Pop();

    if (strike >= armour)
    {
        count++;
        strike -= armour;

        if (soldiers.Any())
        {
            int nextStrike = soldiers.Pop();
            nextStrike += strike;
            soldiers.Push(nextStrike);
        }
        else if (strike > 0)
        {
            soldiers.Push(strike);
        }
    }
    else
    {
        armour -= strike;
        monsters.Enqueue(armour);
    }
}

if (!monsters.Any())
{
    Console.WriteLine("All monsters have been killed!");

}
if (!soldiers.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {count}");