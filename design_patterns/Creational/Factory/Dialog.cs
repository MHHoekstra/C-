using System;

namespace Factory;

public abstract class Dialog
{
    protected abstract Button CreateButton();

    public void Render()
    {
        var okButton = CreateButton();
        okButton.OnClick();
        okButton.Render();
    }
}

