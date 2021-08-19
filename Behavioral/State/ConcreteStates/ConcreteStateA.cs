using System;

namespace DesignPatterns.Behavioral.State.ConcreteStates
{
    public class ConcreteStateA : State

    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request 1");
            Console.WriteLine("ConcreteStateA changes the state of the context");
            Context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request 2");
        }
    }
}
