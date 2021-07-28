using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class SomeProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Result of SomeProductB2";
        }
        
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            string result = collaborator.UsefulFunctionA();

            return "{ Result of SomeProductB2 collaborating with " + result + " }";
        }
    }
}
