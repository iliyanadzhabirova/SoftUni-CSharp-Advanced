int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> numbers = new Queue<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] % 2 == 0)
    {
        numbers.Enqueue(input[i]);
    }
}

Console.WriteLine(string.Join(", ", numbers));