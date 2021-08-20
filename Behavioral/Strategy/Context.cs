using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");

            List<string> result = (List<string>)_strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultString = "";

            foreach (string element in result)
            {
                resultString += element + ", ";
            }

            return resultString;
        }
    }
}
