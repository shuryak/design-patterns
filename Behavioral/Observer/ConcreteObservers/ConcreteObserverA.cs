using System;
using DesignPatterns.Behavioral.Observer.Abstractions;

namespace DesignPatterns.Behavioral.Observer.ConcreteObservers
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event");
            }
        }
    }
}
