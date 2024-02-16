using System.Text;

Stack<int> food = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

List<string> peaks = new List<string>();
int countOfPeaks = 1;
while (food.Count > 0 && stamina.Count > 0)
{
    int currFood = food.Pop();
    int currStanima = stamina.Dequeue();
    int sumOfThem = currFood + currStanima;

    if (sumOfThem >= 80 && countOfPeaks == 1)
    {
        peaks.Add("Vihren");
        countOfPeaks++;
    }
    else if (sumOfThem >= 90 && countOfPeaks == 2)
    {
        peaks.Add("Kutelo");
        countOfPeaks++;
    }
    else if (sumOfThem >= 100 && countOfPeaks == 3)
    {
        peaks.Add("Banski Suhodol");
        countOfPeaks++;
    }
    else if (sumOfThem >= 60 && countOfPeaks == 4)
    {
        peaks.Add("Polezhan");
        countOfPeaks++;
    }
    else if (sumOfThem >= 70 && countOfPeaks == 5)
    {
        peaks.Add("Kamenitza");
        countOfPeaks++;
    }
}
if (peaks.Count == 5)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");

}
if (peaks.Count != 0)
{
    Console.WriteLine("Conquered peaks:");
    StringBuilder sb = new StringBuilder();
    foreach (var item in peaks)
    {
        sb.AppendLine(item.ToString());
    }
    Console.WriteLine(sb.ToString());
}