namespace Builder;

public class Director
{
    public void MakeSuv(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine(new SuvEngine());
    }

    public void MakeSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine(new SportEngine());
        builder.SetTripComputer();
        builder.SetGPS();
    }
}