namespace CarManufacturer;

public class StartUp
{
    public static void Main(string[] args)
    {
        string command = string.Empty;


        List<Tire[]> tiresList = new List<Tire[]>();

        while ((command = Console.ReadLine()) != "No more tires")
        {
            string[] tireInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int firstTireYear = int.Parse(tireInfo[0]);
            double firstTirePressure = double.Parse(tireInfo[1]);
            int secondTireYear = int.Parse(tireInfo[2]);
            double secondTirePressure = double.Parse(tireInfo[3]);
            int thirdTireYear = int.Parse(tireInfo[4]);
            double thirdTirePressure = double.Parse(tireInfo[5]);
            int fourthTireYear = int.Parse(tireInfo[6]);
            double fourthTirePressure = double.Parse(tireInfo[7]);


            Tire tireOne = new Tire(firstTireYear, firstTirePressure);
            Tire tireTwo = new Tire(secondTireYear, secondTirePressure);
            Tire tireThree = new Tire(thirdTireYear, thirdTirePressure);
            Tire tireFour = new Tire(fourthTireYear, fourthTirePressure);

            Tire[] carTires = new Tire[4]
            {
                tireOne,
                tireTwo,
                tireThree,
                tireFour
            };

            tiresList.Add(carTires);
        }



        List<Engine> enginesList = new List<Engine>();

        while ((command = Console.ReadLine()) != "Engines done")
        {
            string[] engineInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int engineHP = int.Parse(engineInfo[0]);
            double engineCubicCapacity = double.Parse(engineInfo[1]);

            Engine currentEngine = new Engine(engineHP, engineCubicCapacity);
            enginesList.Add(currentEngine);
        }



        List<Car> carsList = new List<Car>();

        while ((command = Console.ReadLine()) != "Show special")
        {
            string[] carInfo = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

          
            string make = carInfo[0];
            string model = carInfo[1];
            int year = int.Parse(carInfo[2]);
            double fuelQuantity = double.Parse(carInfo[3]);
            double fuelConsumption = double.Parse(carInfo[4]);
            int engineIndex = int.Parse(carInfo[5]);
            int tireIndex = int.Parse(carInfo[6]);

           
            Engine currentEngine = enginesList[engineIndex];
            Tire[] currentTires = tiresList[tireIndex];

            Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTires);
            carsList.Add(currentCar);
        }

      
        List<Car> filteredCars = carsList
            .Where(x => x.Year >= 2017)
            .Where(x => x.Engine.HorsePower > 330)
            .Where(x => x.Tires.Sum(p => p.Pressure) >= 9
                        && x.Tires.Sum(p => p.Pressure) <= 10)
            .ToList();

       
        foreach (var filteredCar in filteredCars)
        {
            filteredCar.Drive(20);
            Console.WriteLine(filteredCar.WhoAmI());
        }
    }
}