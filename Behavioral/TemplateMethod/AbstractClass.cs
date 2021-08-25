using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass: Base operation.");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass: Base operation..");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass: Base operation...");
        }

        protected abstract void RequiredOperation1();
        
        protected abstract void RequiredOperation2();

        /*
         * Hooks provide additional extension points in some crucial places of the algorithm
         */
        protected virtual void Hook1()
        {
        }

        protected virtual void Hook2()
        {
        }
    }
}
