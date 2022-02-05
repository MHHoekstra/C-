using System;

namespace Factory;

public class WindowsButton : Button
{
    public override void OnClick()
    {
        Console.WriteLine("WindowsButton OnClick");
    }

    public override void Render()
    {
        Console.WriteLine("WindowsButton Render");
    }
}
