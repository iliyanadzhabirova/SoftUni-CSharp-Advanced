string[] initialSongs=Console.ReadLine().Split(", ").ToArray();

Queue<string>songsQueue=new Queue<string>(initialSongs);

while (songsQueue.Any())
{
    string[] input=Console.ReadLine().Split(" ").ToArray();

    if (input[0] == "Play")
    {
        songsQueue.Dequeue();
    }
    else if (input[0] =="Add")
    {
        string songName=string.Join(" ", input.Skip(1));

        if (songsQueue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            songsQueue.Enqueue(songName);
        }
    }
    else if (input[0] == "Show")
    {
        Console.WriteLine(string.Join(", ",songsQueue));
    }
}
Console.WriteLine("No more songs!");