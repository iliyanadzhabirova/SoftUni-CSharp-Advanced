
namespace Generics;
public class StartUp
{
    static void Main()

    {
        int lines=int.Parse(Console.ReadLine());
        Box<double> myBox = new();

        for (int i = 0; i < lines; i++)
        {
            myBox.Add(double.Parse(Console.ReadLine()));
        }
        double compareWith=double.Parse(Console.ReadLine());

        Console.WriteLine(myBox.Count(compareWith));
    }
    
}        
    
