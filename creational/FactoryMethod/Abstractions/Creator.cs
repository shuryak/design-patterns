namespace FactoryMethod.Abstractions
{
    /*
     * Factory Method is a creational design pattern that provides an interface
     * for creating objects in a superclass, but allows subclasses to change 
     * the type of objects that will be created.
     * 
     * Factory method is a method to override returning object.
     */
    public abstract class Creator
    {
        protected abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            string result = "Creator: " + product.Operation();

            return result;
        }
    }
}
