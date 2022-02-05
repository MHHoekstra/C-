using System;

namespace AbstractFactory;

public class WinCheckbox : ICheckbox
{
    public void OnCheck()
    {
        Console.WriteLine("WinCheckbox OnCheck");
    }
}