int length=int.Parse(Console.ReadLine());

string[] names=Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

Predicate<string> predicate= s => s.Length <= length;

var result = names
    .Where(name => predicate(name));

foreach (string s in result)
{
    Console.WriteLine(s);
}

