using System;
using DesignPatterns.Structural.Decorator.Decorators;

namespace DesignPatterns.Structural.Decorator
{
    public class Client
    {
        /*
         * Pattern Decorator allows dynamically adds new behaviors to a class using wrappers
         */
        public void Main()
        {
            IDataSource source = new SomeDataSource();

            source = new ReverseDataDecorator(source);
            source = new EncryptionDecorator(source);
            
            source.WriteData("Hello World");
            Console.WriteLine(source.ReadData());
        }
    }
}
