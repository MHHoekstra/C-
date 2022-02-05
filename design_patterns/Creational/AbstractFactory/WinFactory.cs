namespace AbstractFactory;

public class WinFactory : IFactory
{
    public IButton CreateButton()
    {
        return new WinButton(); 
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}