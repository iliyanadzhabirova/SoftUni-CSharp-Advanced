int lines=int.Parse(Console.ReadLine());

Dictionary<int,bool> numbers=new Dictionary<int,bool>(); 

for(int i = 0; i < lines; i++)
{
   int currentNumber=int.Parse(Console.ReadLine());
    if (numbers.ContainsKey(currentNumber))
    {
        numbers[currentNumber] =! numbers[currentNumber];
    }
    else
    {
        numbers.Add(currentNumber,false);
    }
}
foreach (int number in numbers.Keys)
{
    if (numbers[number])
    {
        Console.WriteLine(number);
    }
}