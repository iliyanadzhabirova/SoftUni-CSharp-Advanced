string command = Console.ReadLine();
HashSet<string> parking = new HashSet<string>();
while (command!="END")
{
    string[] input = command.Split(", ");
    string direction = input[0];
    string carNumber = input[1];

    if (direction == "IN")
    {
        parking.Add(carNumber);
    }
    else if (direction == "OUT")
    {
        parking.Remove(carNumber);
    }
    command = Console.ReadLine();
}
if (parking.Count > 0)
{
    foreach (string carNumber in parking)
    {
        Console.WriteLine(carNumber);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}