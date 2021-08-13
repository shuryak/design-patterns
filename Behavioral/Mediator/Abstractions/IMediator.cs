namespace DesignPatterns.Behavioral.Mediator.Abstractions
{
    public interface IMediator
    {
        void Notify(object sender, string e);
    }
}
