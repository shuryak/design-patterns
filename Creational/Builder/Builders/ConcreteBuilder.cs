using DesignPatterns.Creational.Builder.Abstractions;
using DesignPatterns.Creational.Builder.Products;

namespace DesignPatterns.Creational.Builder.Builders
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        
        public ConcreteBuilder() => Reset();

        public void Reset() => _product = new Product();

        public void BuildPartA() => _product.Add("Part A1");

        public void BuildPartB() => _product.Add("Part B1");

        public void BuildPartC() => _product.Add("Part C1");
        
        public Product GetProduct()
        {
            Product result = this._product;

            Reset();

            return result;
        }
    }
}
