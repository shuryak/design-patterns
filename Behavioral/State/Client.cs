using System;
using DesignPatterns.Behavioral.State.ConcreteStates;

namespace DesignPatterns.Behavioral.State
{
    /*
     * Pattern State allows an object to change its behavior when its internal state changes
     */
    public class Client
    {
        public void Main()
        {
            Context context = new Context(new ConcreteStateA());
            
            context.Request1();
            
            Console.WriteLine();
            
            context.Request2();
        }
    }
}
