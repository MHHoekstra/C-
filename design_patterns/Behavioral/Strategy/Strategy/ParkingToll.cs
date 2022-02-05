namespace Strategy;

public class ParkingToll
{
    private readonly int _hours;
    private readonly Calculation _calculation;
    public ParkingToll(int hours, Calculation calculation)
    {
        this._hours = hours;
        this._calculation = calculation;
    }

    public int Value()
    {
        return _calculation.CalculateToll(_hours);
    }
}