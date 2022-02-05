namespace NullObjectPattern;

public class NoDiscount : IDiscount
{
    public double GiveDiscount(double originalValue)
    {
        return originalValue;
    }
}