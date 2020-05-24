using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Products
{
    public class SomeProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "{Result of SomeProductB1}";
        }
        
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return "{Result of SomeProductB1 collaborating with " + result + "}";
        }
    }
}
