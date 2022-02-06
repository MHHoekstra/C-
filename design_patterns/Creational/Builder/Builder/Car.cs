namespace Builder;

public class Car
{
    public int Seats { get; set; }

    public IEngine? Engine { get; set; }

    public TripComputer? TripComputer { get; set; }

    public GPS? Gps { get; set; }
    
}



