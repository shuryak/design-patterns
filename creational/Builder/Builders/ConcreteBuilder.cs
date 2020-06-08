using Builder.Abstractions;
using Builder.Products;

namespace Builder.Builders
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        
        public ConcreteBuilder() => this.Reset();

        public void Reset() => this._product = new Product();

        public void BuildPartA() => this._product.Add("Part A1");

        public void BuildPartB() => this._product.Add("Part B1");

        public void BuildPartC() => this._product.Add("Part C1");
        
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
