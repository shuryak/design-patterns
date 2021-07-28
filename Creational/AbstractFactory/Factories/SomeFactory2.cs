using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class SomeFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new SomeProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new SomeProductB2();
        }
    }
}
