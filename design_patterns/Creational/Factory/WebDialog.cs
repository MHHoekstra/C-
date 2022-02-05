namespace Factory;


public class WebDialog : Dialog
{
    protected override Button CreateButton()
    {
        return new HtmlButton();
    }
}

