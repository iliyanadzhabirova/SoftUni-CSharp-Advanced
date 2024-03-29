﻿
namespace SpeedRacing;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelledDistance;
    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        TravelledDistance = 0;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TravelledDistance { get; set; }

    public void NeededFuelCalculator(string model, double amountKm)
    {
        double neededFuel = amountKm * this.FuelConsumptionPerKilometer;

        if (this.FuelAmount >= neededFuel)
        {
            this.FuelAmount -= neededFuel;
            this.TravelledDistance += amountKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
