using FactoryMethod.Abstractions;

namespace FactoryMethod.Products
{
    public class SomeProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
