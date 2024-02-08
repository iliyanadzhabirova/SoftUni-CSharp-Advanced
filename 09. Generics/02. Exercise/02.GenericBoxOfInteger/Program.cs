
using Generics;

int lines=int.Parse(Console.ReadLine());

Box<int> intBox = new Box<int>();

for(int i=0; i<lines; i++)
{
    intBox.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine(intBox);
