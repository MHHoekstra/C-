namespace NullObjectPattern;

public class Item
{
    private readonly string _name;
    private readonly double _value;
    private readonly IDiscount _discount;

    public Item(string name, double value, IDiscount discount)
    {
        _name = name;
        _value = value;
        _discount = discount;
    }

    public Item(string name, double value)
    {
        _name = name;
        _value = value;
        _discount = new NoDiscount();
    }

    public override string ToString()
    {
        return $"{_name} R$ {_discount.GiveDiscount(_value)}";
    }
}