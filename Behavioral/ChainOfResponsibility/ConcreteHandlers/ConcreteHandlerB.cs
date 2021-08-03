using DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerB : AbstractHandler
    {
        public override object HandleRequest(object request)
        {
            if ((int) request >= 10 && (int) request < 20)
                return GetType().Name + " handled request " + request;
            return base.HandleRequest(request);
        }
    }
}
