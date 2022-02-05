using System;

namespace Factory;

public class HtmlButton : Button
{
    public override void OnClick()
    {
        Console.WriteLine("HTMLButton OnClick");
    }

    public override void Render()
    {
        Console.WriteLine("HTMLButton Render");
    }
}

