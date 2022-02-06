namespace Builder;

public interface IBuilder
{
    public abstract void Reset();
    public abstract void SetSeats(int seats);
    public abstract void SetEngine(IEngine engine);
    public abstract void SetTripComputer();
    public abstract void SetGPS();
    
}