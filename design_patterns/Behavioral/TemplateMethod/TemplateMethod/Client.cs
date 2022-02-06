namespace TemplateMethod;


class Client
{
    public static void ClientCode(IAbstractClass abstractClass)
    {
        // ...
        abstractClass.TemplateMethod();
        // ...
    }
}