using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class SomeProductA1  : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "{ Result of SomeProductA1 }";
        }
    }
}
