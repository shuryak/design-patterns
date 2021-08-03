namespace DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler; // This allow to do: first.SetNext(second).SetNext(third)...
        }

        public virtual object HandleRequest(object request)
        {
            if (this._nextHandler != null)
                return this._nextHandler.HandleRequest(request);
            return null;
        }
    }
}
