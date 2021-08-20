using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy.ConcreteStrategies
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            List<string> list = data as List<string>;
            
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
