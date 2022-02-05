using System;

namespace AbstractFactory;

public class MacButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("MacButton OnClick");
    }
}