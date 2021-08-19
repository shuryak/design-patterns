using System;

namespace DesignPatterns.Behavioral.State.ConcreteStates
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request 1");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handles request 2");
            Console.WriteLine("ConcreteStateB changes the state of the context");
            Context.TransitionTo(new ConcreteStateA());
        }
    }
}
