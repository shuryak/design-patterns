using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    public class SomeCreator2 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new SomeProduct2();
        }
    }
}
