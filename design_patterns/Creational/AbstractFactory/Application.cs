namespace AbstractFactory;

public static class Application
{
    public static void Main(string[] args)
    {
        IFactory factory1 = new WinFactory();
        IFactory factory2 = new MacFactory();

        IButton winButton = factory1.CreateButton();
        IButton macButton = factory2.CreateButton();

        winButton.OnClick();
        macButton.OnClick();
    }
}