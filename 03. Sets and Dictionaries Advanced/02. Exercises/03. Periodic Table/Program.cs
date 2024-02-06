int lines=int.Parse(Console.ReadLine());
SortedSet<string> chemicalCompounds=new SortedSet<string>();
for(int i=0; i<lines; i++)
{
    string[] elements=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in elements)
    {
        chemicalCompounds.Add(element);
    }
}

foreach (string element in chemicalCompounds)
{
    Console.Write(element + " ");
}

