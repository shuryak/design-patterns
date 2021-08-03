namespace DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object HandleRequest(object request);
    }
}
