using FactoryMethod.Abstractions;

namespace FactoryMethod.Products
{
    public class SameProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
