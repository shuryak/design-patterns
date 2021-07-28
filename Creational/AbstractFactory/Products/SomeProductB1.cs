using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class SomeProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "{ Result of SomeProductB1 }";
        }
        
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            string result = collaborator.UsefulFunctionA();

            return "{ Result of SomeProductB1 collaborating with " + result + " }";
        }
    }
}
