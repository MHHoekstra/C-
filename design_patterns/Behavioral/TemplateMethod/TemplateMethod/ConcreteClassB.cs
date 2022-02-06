using System;

namespace TemplateMethod;

public class ConcreteClassB : IAbstractClass
{
    public void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
    }

    public void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
    }

    public void Hook1()
    {
        Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
    }

    public void Hook2()
    {
        Console.WriteLine("ConcreteClass2 says: Overridden Hook2");
    }
}