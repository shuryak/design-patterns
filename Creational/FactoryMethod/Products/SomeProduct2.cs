using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class SomeProduct2 : IProduct
    {
        public string Operation()
        {
            return "{ Result of SomeProduct2 }";
        }
    }
}
