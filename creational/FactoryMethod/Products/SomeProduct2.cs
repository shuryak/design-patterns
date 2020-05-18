using FactoryMethod.Abstractions;

namespace FactoryMethod.Products
{
    public class SameProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
