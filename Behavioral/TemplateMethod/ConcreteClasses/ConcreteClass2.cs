using System;

namespace DesignPatterns.Behavioral.TemplateMethod.ConcreteClasses
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("ConcreteClass2: Implemented RequiredOperation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2: Implemented RequiredOperation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2: Overridden Hook1");
        }
    }
}
