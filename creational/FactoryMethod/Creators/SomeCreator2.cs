using FactoryMethod.Abstractions;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class SomeCreator2 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new SomeProduct2();
        }
    }
}
