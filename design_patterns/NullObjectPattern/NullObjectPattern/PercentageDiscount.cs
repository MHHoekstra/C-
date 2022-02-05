namespace NullObjectPattern;

public class PercentageDiscount : IDiscount
{
    private readonly double _discountPercentage;

    public PercentageDiscount(double discountPercentage)
    {
        _discountPercentage = discountPercentage;
    }

    public double GiveDiscount(double originalValue)
    {
        return originalValue - originalValue * _discountPercentage;
    }
    
}