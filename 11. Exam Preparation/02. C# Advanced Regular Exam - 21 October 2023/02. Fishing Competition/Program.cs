using System.Threading.Channels;

namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] fishingArea = new char[size, size];

            int boatRow = 0;
            int boatCol = 0;

            for (int row = 0; row < size; row++)
            {
                string rowValues = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    fishingArea[row, col] = rowValues[col];
                    if (rowValues[col] == 'S')
                    {
                        boatRow = row;
                        boatCol = col;
                    }
                }
            }

            int neededQuota = 20;
            int caughtFish = 0;
            bool isInWhirpool = false;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "collect the nets")
            {
                fishingArea[boatRow, boatCol] = '-';

                if (input == "up")
                {
                    if (boatRow == 0)
                    {
                        boatRow = size - 1;
                    }
                    else
                    {
                        boatRow -= 1;
                    }
                }
                else if (input == "down")
                {
                    if (boatRow == size - 1)
                    {
                        boatRow = 0;
                    }
                    else
                    {
                        boatRow += 1;
                    }
                }
                else if (input == "left")
                {
                    if (boatCol == 0)
                    {
                        boatCol = size - 1;
                    }
                    else
                    {
                        boatCol -= 1;
                    }
                }
                else if (input == "right")
                {
                    if (boatCol == size - 1)
                    {
                        boatCol = 0;
                    }
                    else
                    {
                        boatCol += 1;
                    }
                }

                if (char.IsDigit(fishingArea[boatRow, boatCol]))
                {
                    caughtFish += int.Parse(fishingArea[boatRow, boatCol].ToString());
                    fishingArea[boatRow, boatCol] = '-';
                }

                if (fishingArea[boatRow, boatCol] == 'W')
                {
                    Console.WriteLine(
                        $"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{boatRow},{boatCol}]");
                    isInWhirpool = true;
                    break;
                }

                fishingArea[boatRow, boatCol] = 'S';
            }

            if (isInWhirpool == false)
            {
                if (neededQuota <= caughtFish)
                {
                    Console.WriteLine($"Success! You managed to reach the quota!");
                }
                else
                {
                    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {neededQuota - caughtFish} tons of fish more.");
                }

                if (caughtFish > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");
                }

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write($"{fishingArea[row, col]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}