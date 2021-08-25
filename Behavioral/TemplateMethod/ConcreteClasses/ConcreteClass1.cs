using System;

namespace DesignPatterns.Behavioral.TemplateMethod.ConcreteClasses
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass1: Implemented RequiredOperation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1: Implemented RequiredOperation2");
        }
    }
}
