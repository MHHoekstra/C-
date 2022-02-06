using System;

namespace TemplateMethod;

public interface IAbstractClass
{
    public void TemplateMethod()
    {
        this.BaseOperation1();
        this.RequiredOperation1();
        this.BaseOperation2();
        this.Hook1();
        this.RequiredOperation2();
        this.BaseOperation3();
        this.Hook2();
    }
    
    void BaseOperation1()
    {
        Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
    }
    void BaseOperation2()
    {
        Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
  
    }
    void BaseOperation3()
    {
        Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
    }
    abstract void RequiredOperation1();
    abstract void RequiredOperation2();

    virtual void Hook1()
    {
    }

    virtual void Hook2()
    {
    }

}