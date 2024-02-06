double[] numbers=Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(x=>x*1.2)
    .ToArray();

foreach (var number in numbers)
{
    Console.WriteLine($"{number:f2}");
}