using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy.ConcreteStrategies
{
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            List<string> list = data as List<string>;

            list.Sort();

            return list;
        }
    }
}
