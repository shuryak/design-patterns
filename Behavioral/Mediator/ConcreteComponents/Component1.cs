using System;
using DesignPatterns.Behavioral.Mediator.Abstractions;

namespace DesignPatterns.Behavioral.Mediator.ConcreteComponents
{
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A...");
            
            Mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B...");
            
            Mediator.Notify(this, "B");
        }
    }
}
