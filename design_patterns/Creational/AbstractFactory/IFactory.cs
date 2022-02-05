namespace AbstractFactory;

public interface IFactory
{
    public abstract IButton CreateButton();
    public abstract ICheckbox CreateCheckbox();
}