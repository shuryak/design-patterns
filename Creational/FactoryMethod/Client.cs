using System;
using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Creators;

namespace DesignPatterns.Creational.FactoryMethod
{
    /*
     * Factory Method is a creational design pattern that provides an interface 
     * for creating objects in a superclass, but allows subclasses to change 
     * the type of objects that will be created.
     * 
     * Factory method is a method to override returning object.
     */
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Start SomeCreator1");
            StartCreator(new SomeCreator1());
            
            Console.WriteLine("");
            
            Console.WriteLine("App: Start SomeCreator2");
            StartCreator(new SomeCreator2());
        }

        private void StartCreator(Creator creator)
        {
            Console.WriteLine("Client: Start " + creator.GetType().Name + ".SomeOperation.\n"
                              + creator.SomeOperation());
        }
    }
}
