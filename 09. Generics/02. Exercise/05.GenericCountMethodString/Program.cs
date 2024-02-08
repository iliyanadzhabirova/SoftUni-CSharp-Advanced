
namespace Generics;
public class StartUp
{
    static void Main()

    {
        int lines=int.Parse(Console.ReadLine());
        Box<string> myBox = new();

        for (int i = 0; i < lines; i++)
        {
            myBox.Add(Console.ReadLine());
        }
        string compareWith=Console.ReadLine();

        Console.WriteLine(myBox.Count(compareWith));
    }
    
}        
    
