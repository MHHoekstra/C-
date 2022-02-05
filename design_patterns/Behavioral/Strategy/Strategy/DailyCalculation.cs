using System;

namespace Strategy;

public class DailyCalculation : Calculation
{
    private readonly int _dailyValue;
    public DailyCalculation(int dailyValue)
    {
        _dailyValue = dailyValue;
    }

    public int CalculateToll(int hours)
    {
        var days = (hours / 24) + 1;
        Console.WriteLine(hours);
        return _dailyValue * days;
    }
}
