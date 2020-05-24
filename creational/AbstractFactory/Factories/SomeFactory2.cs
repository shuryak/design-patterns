using AbstractFactory.Abstractions;
using AbstractFactory.Abstractions.Products;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
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
