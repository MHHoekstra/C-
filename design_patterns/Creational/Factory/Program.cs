using Factory;

public class Program
{
    public static void Main(string[] args)
    {
        var windowsApp = new Application("Windows");
        var webApp = new Application("Web");
        
        windowsApp.Initialize();
        webApp.Initialize();
    }
}