using System;

namespace AbstractFactory;

public class MacCheckbox : ICheckbox
{
    public void OnCheck()
    {
        Console.WriteLine("MacCheckbox OnCheck");
    }
}