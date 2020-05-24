using AbstractFactory.Abstractions;
using AbstractFactory.Abstractions.Products;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class SomeFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new SomeProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new SomeProductB1();
        }
    }
}
