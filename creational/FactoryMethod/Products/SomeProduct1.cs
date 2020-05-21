using FactoryMethod.Abstractions;

namespace FactoryMethod.Products
{
    public class SomeProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
