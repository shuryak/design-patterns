namespace DesignPatterns.Creational.AbstractFactory.Abstractions.Products
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
