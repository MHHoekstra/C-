using System;

namespace AbstractFactory;

public class WinButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("WinButton OnClick");
    }
}