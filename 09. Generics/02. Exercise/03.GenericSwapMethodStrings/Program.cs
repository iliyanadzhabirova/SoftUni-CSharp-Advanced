
namespace Generics;
public class StartUp
{
    static void Main()

    {
        int lines=int.Parse(Console.ReadLine());
        List<string> list = new List<string>(); 

        for (int i = 0; i < lines; i++)
        {
            list.Add(Console.ReadLine());

        }
        int[] indexes = Console.ReadLine()
            .Split(' ',StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        GenericSwap(list, indexes[0], indexes[1]);

        foreach (var item in list)
        {
            Console.WriteLine($"{item.GetType()}: {item}");
        }
    }
    public static void GenericSwap<T>(List<T> items, int firstIndex, int secondIndex)
    {
        //Option 1
        //T temp = items[firstIndex];
        //items[firstIndex] = items[secondIndex];
        //items[secondIndex] = temp;

        //Option2
        (items[firstIndex], items[secondIndex]) = (items[secondIndex], items[firstIndex]);  

    }
}        
    
