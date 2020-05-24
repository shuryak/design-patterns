using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Products
{
    public class SomeProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "{Result of SomeProductA2}";
        }
    }
}
