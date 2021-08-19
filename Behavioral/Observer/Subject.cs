using System;
using System.Collections.Generic;
using DesignPatterns.Behavioral.Observer.Abstractions;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : ISubject
    {
        public int State { get; set; } = 0;

        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void Register(IObserver observer)
        {
            Console.WriteLine("Subject: Observer was registered");
            _observers.Add(observer);
        }

        public void Deregister(IObserver observer)
        {
            Console.WriteLine("Subject: Observer was deregistered");
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine();
            
            State++;
            Console.WriteLine("Subject: State has changed to: " + State);

            Notify();
        }
    }
}
