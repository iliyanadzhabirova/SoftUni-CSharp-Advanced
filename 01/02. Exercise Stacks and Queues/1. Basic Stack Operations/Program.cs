//string[] input = Console.ReadLine().Split(separator:' ');

//int n = int.Parse(input[0]);
//int s = int.Parse(input[1]);
//int x = int.Parse(input[2]);

int[] input=Console.ReadLine().Split(separator:' ').Select(int.Parse).ToArray();

string[] secondLine = Console.ReadLine().Split(separator:' ');

Stack<int> integerStack = new();

foreach (var s in secondLine)
{
    int temp=int.Parse(s);
    integerStack.Push(temp);
}

for (int i = 0; i < input[1]; i++)
{
    integerStack.Pop();
}

if (integerStack.Contains(input[2]))
{
    Console.WriteLine("true");
}
else if (integerStack.Any())
{
    Console.WriteLine(integerStack.Min());
}
else
{
    Console.WriteLine(0);
}
