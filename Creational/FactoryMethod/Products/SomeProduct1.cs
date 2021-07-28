using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Products
{
    public class SomeProduct1 : IProduct
    {
        public string Operation()
        {
            return "{ Result of SomeProduct1 }";
        }
    }
}
