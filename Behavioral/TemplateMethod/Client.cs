using System;
using DesignPatterns.Behavioral.TemplateMethod.ConcreteClasses;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    /*
     * Template Method defined the skeleton of an algorithm in the superclass but lets subclasses override specific
     * steps of the algorithm without changing its structure
     */
    public class Client
    {
        public void Main()
        {
            new ConcreteClass1().TemplateMethod();
            
            Console.WriteLine();
            
            new ConcreteClass2().TemplateMethod();
        }
    }
}
