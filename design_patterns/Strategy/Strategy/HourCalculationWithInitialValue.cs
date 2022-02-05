namespace Strategy;

public class HourCalculationWithInitialValue : Calculation
{
    private readonly int _initialValue;
    private readonly int _perHour;
    public HourCalculationWithInitialValue(int initialValue, int perHour)
    {
        _initialValue = initialValue;
        _perHour = perHour;
    }

    public int CalculateToll(int hours)
    {
        return _initialValue + hours * _perHour;
    }
}
