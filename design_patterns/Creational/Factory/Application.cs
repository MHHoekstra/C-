using Factory;

namespace Factory;

public class Application
{
    private readonly Dialog _dialog;

    public Application(string os)
    {
        if (os == "Windows")
        {
            _dialog = new WindowsDialog();
        }
        else
        {
            _dialog = new WebDialog();
        }
    }

    public void Initialize()
    {
        _dialog.Render();
    }

}