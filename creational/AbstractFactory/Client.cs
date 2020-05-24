using System;
using AbstractFactory.Abstractions;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    /*
     * Abstarct factory providing interface for concrete factories.
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
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

    }
}
