namespace Strategy;

public class HourCalculation : Calculation
{
    private readonly int _hourValue;
    public HourCalculation(int hourValue)
    {
        _hourValue = hourValue;
    }

    public int CalculateToll(int hours)
    {
        return hours * _hourValue;
    }
}