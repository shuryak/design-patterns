using System;
using DesignPatterns.Structural.Adapter.Abstractions;
using DesignPatterns.Structural.Adapter.Services;

namespace DesignPatterns.Structural.Adapter
{
    /*
     * Pattern Adapter converts wrong interface of one class to target interface of another class, which clients are
     * expecting
     */
    public class Client
    {
        public void Main()
        {
            ITarget target = new StandardService();
            Console.WriteLine(target.GetRequest());
                        
            IncompatibleService incompatibleService = new IncompatibleService();
            target = new global::DesignPatterns.Structural.Adapter.Adapter(incompatibleService);
            Console.WriteLine(target.GetRequest());
        }
    }
}
