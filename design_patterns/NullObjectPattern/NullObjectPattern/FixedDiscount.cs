namespace NullObjectPattern;

public class FixedDiscount : IDiscount
{
    private readonly double _discountValue;

    public FixedDiscount(double discountValue)
    {
        _discountValue = discountValue;
    }


    public double GiveDiscount(double originalValue)
    {
        return originalValue - _discountValue;
    }
}