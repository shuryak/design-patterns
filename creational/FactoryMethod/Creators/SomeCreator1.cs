using FactoryMethod.Abstractions;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class SomeCreator1 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new SameProduct1();
        }
    }
}
