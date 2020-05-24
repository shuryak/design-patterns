using AbstractFactory.Abstractions.Products;

namespace AbstractFactory.Abstractions
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
