Stack<int> money = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> prices = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int foodCounter = 0;
while (money.Any() && prices.Any())
{
    int moneyValue = money.Pop();
    int priceValue = prices.Dequeue();

    if (moneyValue == priceValue)
    {
        foodCounter++;
        continue;
    }
    else if (moneyValue > priceValue)
    {
        foodCounter++;
        int difference = moneyValue - priceValue;
        if (money.Any())
        {
            moneyValue = money.Pop();
            int nextElement = moneyValue + difference;
            money.Push(nextElement);
        }

    }
    else if (moneyValue > priceValue)
    {
        continue;
    }
}
if (foodCounter >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodCounter} foods.");
}
else if (foodCounter < 4 && foodCounter > 1)
{
    Console.WriteLine($"Henry ate: {foodCounter} foods.");
}
else if (foodCounter == 1)
{
    Console.WriteLine($"Henry ate: {foodCounter} food.");
}
else if (foodCounter == 0)
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}