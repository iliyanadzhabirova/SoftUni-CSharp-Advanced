int greenLightSeconds=int.Parse(Console.ReadLine());
int freeWindowSeconds=int.Parse(Console.ReadLine());

string command = Console.ReadLine();
Queue<string>cars = new Queue<string>();
int passedcras = 0;
while (command!="END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        command = Console.ReadLine();
        continue;
    }

    int currentGreenLightSeconds = greenLightSeconds;
    while (cars.Count>0 && currentGreenLightSeconds>0)
    {
        string currentcar = cars.Dequeue();

        if (currentGreenLightSeconds - currentcar.Length >= 0)
        {
            currentGreenLightSeconds -= currentcar.Length;
            passedcras++;
            continue;
        }
        else if (currentGreenLightSeconds + freeWindowSeconds - currentcar.Length >= 0)
        {
            passedcras++;
            break;
        }
        else 
        {
            char hittedSymbol = currentcar[currentGreenLightSeconds + freeWindowSeconds];
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currentcar} was hit at {hittedSymbol}.");

            Environment.Exit(0);
        }

    }
    
    command = Console.ReadLine();
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedcras} total cars passed the crossroads.");  
