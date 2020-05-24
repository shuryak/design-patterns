using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Products
{
    public class SomeProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Result of SomeProductB2";
        }
        
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return "{Result of SomeProductB2 collaborating with " + result + "}";
        }
    }
}
