using System;
using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;
using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory
{
    /*
     * Abstract factory providing interface for concrete factories.
     * 
     * Abstract factory is a bunch of factory methods.
     */
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: First factory type...");
            ClientMethod(new SomeFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Second factory type...");
            ClientMethod(new SomeFactory2());
        }

        private void ClientMethod(IAbstractFactory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

    }
}
