using System;

namespace TemplateMethod;

public class ConcreteClassA : IAbstractClass
{
    public void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
    }

    public void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
    }
    
}