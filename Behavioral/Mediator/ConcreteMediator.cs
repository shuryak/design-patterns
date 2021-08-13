using System;
using DesignPatterns.Behavioral.Mediator.Abstractions;
using DesignPatterns.Behavioral.Mediator.ConcreteComponents;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly Component1 _component1;
        private readonly Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string e)
        {
            if (e == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                _component2.DoC();
            }
            else if (e == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                _component1.DoB();
                _component2.DoC();
            }
        }
    }
}
