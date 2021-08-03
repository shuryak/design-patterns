using System;
using DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandlerA : AbstractHandler
    {
        public override object HandleRequest(object request)
        {
            if ((int) request >= 0 && (int) request < 10)
                return GetType().Name + " handled request " + request;
            return base.HandleRequest(request);
        }
    }
}
