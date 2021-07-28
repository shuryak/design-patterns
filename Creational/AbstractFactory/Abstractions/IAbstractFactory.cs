using DesignPatterns.Creational.AbstractFactory.Abstractions.Products;

namespace DesignPatterns.Creational.AbstractFactory.Abstractions
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
