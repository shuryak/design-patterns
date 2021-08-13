using System;
using DesignPatterns.Behavioral.Mediator.ConcreteComponents;

namespace DesignPatterns.Behavioral.Mediator
{
    /*
     * Pattern Mediator defines an object that reduces coupling between program components by making them communicate
     * indirectly, through a special mediator object
     */
    public class Client
    {
        public void Main()
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            new ConcreteMediator(component1, component2);
            
            Console.WriteLine("Client triggers operation A.");
            component1.DoA();
            
            Console.WriteLine();
            
            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
