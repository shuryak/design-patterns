using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Products
{
    public class SomeProductA1  : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "{Result of SomeProductA1}";
        }
    }
}
