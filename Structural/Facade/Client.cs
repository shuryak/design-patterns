using System;
using DesignPatterns.Structural.Facade.Systems;

namespace DesignPatterns.Structural.Facade
{
    public class Client
    {
        /*
         * Pattern Facade provides a simplified (but limited) interface to a complex system of classes
         * 
         * Facade encapsulates complicated system logic in a simple interface
         */
        public void Main()
        {
            MathSubsystem math = new MathSubsystem(); // complex subsystem object
            LogicSubsystem logic = new LogicSubsystem(); // complex subsystem object

            Calculator calc = new Calculator(math, logic); // facade
            
            Console.WriteLine(calc.Calculate(2, 2));
        }
    }
}
