using System;
using FactoryMethod.Abstractions;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Start SomeCreator1");
            StartCreator(new SomeCreator1());
            
            Console.WriteLine("");
            
            Console.WriteLine("App: Start SomeCreator2");
            StartCreator(new SomeCreator2());
        }

        private void StartCreator(Creator creator)
        {
            Console.WriteLine("Client: Start " + creator.GetType().Name + ".SomeOperation.\n" + creator.SomeOperation());
        }
    }
}
