namespace SpeedRacing;

public class StartUp 
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            string model = data[0];
            double fuelAmount = double.Parse(data[1]);
            double fuelConsumptionPerKilometer = double.Parse(data[2]);

            Car currentCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

            cars.Add(currentCar);
        }       
        string command=Console.ReadLine();

        while (command != "End")
        {
            string[] carInfo = command
                        .Split(' ')
                        .ToArray();

            string model = carInfo[1];
            double amountKm = double.Parse(carInfo[2]);

            Car drivingCar = cars
                .Where(x => x.Model == model)
                .ToList()
                .First();

            drivingCar.NeededFuelCalculator(model, amountKm);

            command = Console.ReadLine();
        }

        foreach (var item in cars)
        {
            Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
        }
    }
}