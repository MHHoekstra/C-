using System;

namespace TemplateMethod;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Same client code can work with different subclasses:");
       Client.ClientCode(new ConcreteClassA());
        
            
        Console.WriteLine("Same client code can work with different subclasses:");
        Client.ClientCode(new ConcreteClassB());

    }
}