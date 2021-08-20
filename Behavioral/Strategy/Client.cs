using System;
using DesignPatterns.Behavioral.Strategy.ConcreteStrategies;

namespace DesignPatterns.Behavioral.Strategy
{
    /*
     * Pattern Strategy defines a family of algorithms and make them interchangeable
     */
    public class Client
    {
        public void Main()
        {
            Context context = new Context();
            
            Console.WriteLine("Client: Strategy is set to normal sorting");
            context.SetStrategy(new ConcreteStrategyA());
            Console.WriteLine(context.DoSomeBusinessLogic());
            
            Console.WriteLine();
            
            Console.WriteLine("Client: Strategy is set to reverse sorting");
            context.SetStrategy(new ConcreteStrategyB());
            Console.WriteLine(context.DoSomeBusinessLogic());
        }
    }
}
