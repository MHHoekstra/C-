using System;

namespace StaticFactoryMethod;

public class RandomIntGenerator
{
    public int Min { get; }

    public int Max { get; }

    private RandomIntGenerator(int min, int max)
    {
        Min = min;
        Max = max;
    }


    public static RandomIntGenerator Between(int min, int max)
    {
        return new RandomIntGenerator(min, max);
    }

    public static RandomIntGenerator GreaterThan(int min)
    {
        return new RandomIntGenerator(min, int.MaxValue);
    }

    public static RandomIntGenerator SmallerThan(int max)
    {
        return new RandomIntGenerator(int.MinValue, max);
    }
}