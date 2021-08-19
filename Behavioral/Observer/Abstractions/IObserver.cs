namespace DesignPatterns.Behavioral.Observer.Abstractions
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
