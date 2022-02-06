namespace Observer;

public interface IObserver
{
    public abstract void Update(ISubject subject);
}