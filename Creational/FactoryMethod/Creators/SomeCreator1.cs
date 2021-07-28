using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Creators
{
    public class SomeCreator1 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new SomeProduct1();
        }
    }
}
