namespace IteratorsAndComparators;
public class StartUp
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

        Lake lake = new Lake(list);

        string result = string.Join(", ", lake);
        Console.WriteLine(result);
    }
}