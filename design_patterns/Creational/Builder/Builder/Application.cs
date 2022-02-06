using System;

namespace Builder;

public class Application
{
    public static void Main(string[] args)
    {
        var director = new Director();
        var builder = new CarBuilder();
        director.MakeSportsCar(builder);
        var car = builder.GetResult();
        
        Console.WriteLine($"Number of seats {car.Seats}");
        Console.WriteLine($"Engine {car.Engine}");
        Console.WriteLine($"Gps {car.Gps}");
        Console.WriteLine($"TripComputer {car.TripComputer}");
        
        director.MakeSuv(builder);
        
        var suv = builder.GetResult();
        
        Console.WriteLine($"Number of seats {suv.Seats}");
        Console.WriteLine($"Engine {suv.Engine}");
        Console.WriteLine($"Gps {suv.Gps}");
        Console.WriteLine($"TripComputer {suv.TripComputer}");
    }
}