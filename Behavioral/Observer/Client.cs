using DesignPatterns.Behavioral.Observer.ConcreteObservers;

namespace DesignPatterns.Behavioral.Observer
{
    /*
     * Pattern Observer allows some objects to automatically notify other objects about changes in their state
     *
     * Observer is the "View" part of Model-View-Controller.
     */
    public class Client
    {
        public void Main()
        {
            Subject subject = new Subject();
            ConcreteObserverA observerA = new ConcreteObserverA();
            subject.Register(observerA);

            ConcreteObserverB observerB = new ConcreteObserverB();
            subject.Register(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Deregister(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
