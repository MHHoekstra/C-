namespace Factory;

public class WindowsDialog : Dialog
{
    protected override Button CreateButton()
    {
        return new WindowsButton();
    }
}