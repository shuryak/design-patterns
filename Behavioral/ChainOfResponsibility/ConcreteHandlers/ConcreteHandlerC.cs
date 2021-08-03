using DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerC : AbstractHandler
    {
        public override object HandleRequest(object request)
        {
            if ((int) request >= 20 && (int) request < 30)
                return GetType().Name + " handled request " + request;
            return base.HandleRequest(request);
        }
    }
}
