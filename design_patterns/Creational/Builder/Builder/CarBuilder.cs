namespace Builder;

public class CarBuilder: IBuilder
{
    public Car? car;
    public void Reset()
    {
        car = new Car();
    }

    public void SetSeats(int seats)
    {
        car.Seats = seats;
    }

    public void SetEngine(IEngine engine)
    {
        car.Engine = engine;
    }

    public void SetTripComputer()
    {
        car.TripComputer = new TripComputer();
    }

    public void SetGPS()
    {
        car.Gps = new GPS();
    }

    public Car GetResult()
    {
        return car;
    }
}