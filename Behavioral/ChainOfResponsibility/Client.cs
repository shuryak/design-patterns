using System;
using DesignPatterns.Behavioral.ChainOfResponsibility.Abstractions;
using DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Client
    {
        /*
         * Pattern Chain of Responsibility allows passing request along the chain of potential handlers until one of
         * them handles request
         */
        public void Main()
        {
            IHandler handlerA = new ConcreteHandlerA();
            IHandler handlerB = new ConcreteHandlerB();
            IHandler handlerC = new ConcreteHandlerC();

            handlerA.SetNext(handlerB).SetNext(handlerC);
            
            int[] requests = { 2, 5, 7, 14, 18, 3, 20, 21, 24 };

            foreach (int request in requests)
            {
                Console.WriteLine(handlerA.HandleRequest(request));
            }
        }
    }
}
