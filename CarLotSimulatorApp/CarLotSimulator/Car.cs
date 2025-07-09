using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string EngineNoise)
    {
        Console.WriteLine($"Engine Noise: {EngineNoise}");
    }

    public void MakeHonkNoise(string HonkNoise)
    {
        Console.WriteLine($"Honk Noise: {HonkNoise}");
    }

    public void DisplayFields()
    {
        if (IsDriveable == true)
        {
            Console.WriteLine($"The car is a {Year} {Make} {Model} with a {EngineNoise} engine noise, a {HonkNoise} honk noise and is drivable.");
        }
        else
        {
            Console.WriteLine($"The car is a {Year} {Make} {Model} with a {EngineNoise} engine noise, a {HonkNoise} honk noise and is not drivable.");
        }
    }

    public Car()
    {
        
    }
    
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
    }
}