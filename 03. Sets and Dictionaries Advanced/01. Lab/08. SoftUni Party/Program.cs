HashSet<string> vipGuests = new HashSet<string>();
HashSet<string> regularGuests = new HashSet<string>();
string command = Console.ReadLine();

while (command != "PARTY")
{
    if (Char.IsDigit(command[0]))
    {
        vipGuests.Add(command);
    }
    else
    {
        regularGuests.Add(command);
    }
    command = Console.ReadLine();
}

command = Console.ReadLine();
while (command != "END")
{
    if (Char.IsDigit(command[0]))
    {
        vipGuests.Remove(command);
    }
    else
    {
        regularGuests.Remove(command);
    }
    command = Console.ReadLine();
}

Console.WriteLine(regularGuests.Count + vipGuests.Count);
foreach (var guest in vipGuests)
{
    Console.WriteLine(guest);
}
foreach (var guest in regularGuests)
{
    Console.WriteLine(guest);
}