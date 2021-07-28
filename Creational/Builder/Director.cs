using DesignPatterns.Creational.Builder.Abstractions;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set => _builder = value; 
        }
        
        public void BuildMinimalViableProduct() => this._builder.BuildPartA();

        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}
