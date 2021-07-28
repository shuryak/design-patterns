using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.Products
{
    public class Product
    {
        private readonly List<object> _parts = new List<object>();
        
        public void Add(string part) => this._parts.Add(part);

        public string ListParts()
        {
            string str = string.Join(", ", _parts);

            return "Product parts: " + str + "\n";
        }
    }
}
